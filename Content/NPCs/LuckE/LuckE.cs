﻿using luckeitems.Content.Items.Consumables;
using luckeitems.Content.Items.Materials.Ore;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace luckeitems.Content.NPCs.LuckE
{
    // All of this bosses AI is temporary until I get around to making it
	// The main part of the boss, usually refered to as "body"
	[AutoloadBossHead] // This attribute looks for a texture called "ClassName_Head_Boss" and automatically registers it as the NPC boss head icon
	public class LuckE : ModNPC
	{
        public Vector2 FirstStageDestination
        {
            get => new Vector2(NPC.ai[1], NPC.ai[2]);
            set
            {
                NPC.ai[1] = value.X;
                NPC.ai[2] = value.Y;
            }
        }
        public Vector2 LastFirstStageDestination { get; set; } = Vector2.Zero;
        private const int FirstStageTimerMax = 90;
        // This is a reference property. It lets us write FirstStageTimer as if it's NPC.localAI[1], essentially giving it our own name
        public ref float FirstStageTimer => ref NPC.localAI[1];
        public override void Load()
        {

        }


        public override void SetStaticDefaults() {
			DisplayName.SetDefault("The Creator LuckE");
			Main.npcFrameCount[Type] = 2;

			// Add this in for bosses that have a summon item, requires corresponding code in the item (See MinionBossSummonItem.cs)
			NPCID.Sets.MPAllowedEnemies[Type] = true;
			// Automatically group with other bosses
			NPCID.Sets.BossBestiaryPriority.Add(Type);

			// Specify the debuffs it is immune to
			NPCDebuffImmunityData debuffData = new NPCDebuffImmunityData {
				SpecificallyImmuneTo = new int[] {
					BuffID.Confused // Most NPCs have this
				}
			};
			NPCID.Sets.DebuffImmunitySets.Add(Type, debuffData);
		}

		public override void SetDefaults() {
            NPC.width = 110;
			NPC.height = 110;
			NPC.damage = 1000;
			NPC.defense = 70;
			NPC.lifeMax = 1000000;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.DeathSound = SoundID.NPCDeath1;
			NPC.knockBackResist = 100f;
			NPC.noGravity = true;
			NPC.noTileCollide = true;
			NPC.value = Item.buyPrice(gold: 5);
			NPC.SpawnWithHigherTime(30);
			NPC.boss = true;
			NPC.npcSlots = 10f; // Take up open spawn slots, preventing random NPCs from spawning during the fight

			// Don't set immunities like this as of 1.4:
			// NPC.buffImmune[BuffID.Confused] = true;
			// immunities are handled via dictionaries through NPCID.Sets.DebuffImmunitySets

			// Custom AI, 0 is "bound town NPC" AI which slows the NPC down and changes sprite orientation towards the target
			NPC.aiStyle = -1;
			// The following code assigns a music track to the boss in a simple way.
			if (!Main.dedServ) {
				Music = MusicLoader.GetMusicSlot(Mod, "Assets/Music/DiscoPhial");
			}
		}
        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            // Do NOT misuse the ModifyNPCLoot and OnKill hooks: the former is only used for registering drops, the latter for everything else

            // Add the treasure bag using ItemDropRule.BossBag (automatically checks for expert mode)
            npcLoot.Add(ItemDropRule.BossBag(ModContent.ItemType<LuckEBossBag>()));

            // All our drops here are based on "not expert", meaning we use .OnSuccess() to add them into the rule, which then gets added
            LeadingConditionRule notExpertRule = new LeadingConditionRule(new Conditions.NotExpert());

            // Notice we use notExpertRule.OnSuccess instead of npcLoot.Add so it only applies in normal mode
            // Boss masks are spawned with 1/7 chance
            notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<SlimedOre>(), 1, 10, 10));

            // This part is not required for a boss and is just showcasing some advanced stuff you can do with drop rules to control how items spawn
            // We make 12-15 ExampleItems spawn randomly in all directions, like the lunar pillar fragments. Hereby we need the DropOneByOne rule,
            // which requires these parameters to be defined

            // Finally add the leading rule
            npcLoot.Add(notExpertRule);
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry) {
			// Sets the description of this NPC that is listed in the bestiary
			bestiaryEntry.Info.AddRange(new List<IBestiaryInfoElement> {
				new MoonLordPortraitBackgroundProviderBestiaryInfoElement(), // Plain black background
				new FlavorTextBestiaryInfoElement("The Creator himself, defeating him seems to have no effect... Yet...")
			});
		}
		public override void OnSpawn(IEntitySource source)
		{
            SoundEngine.PlaySound(SoundID.Meowmere, Entity.position);
        }
        public override void OnKill() {
			// Since this hook is only ran in singleplayer and serverside, we would have to sync it manually.
			// Thankfully, vanilla sends the MessageID.WorldData packet if a BOSS was killed automatically, shortly after this hook is ran

			// If your NPC is not a boss and you need to sync the world (which includes ModSystem, check DownedBossSystem), use this code:
			/*
			if (Main.netMode == NetmodeID.Server) {
				NetMessage.SendData(MessageID.WorldData);
			}
			*/
		}

		public override void BossLoot(ref string name, ref int potionType) {
			// Here you'd want to change the potion type that drops when the boss is defeated. Because this boss is early pre-hardmode, we keep it unchanged
			// (Lesser Healing Potion). If you wanted to change it, simply write "potionType = ItemID.HealingPotion;" or any other potion type
		}

		public override bool CanHitPlayer(Player target, ref int cooldownSlot) {
			cooldownSlot = ImmunityCooldownID.Bosses; // use the boss immunity cooldown counter, to prevent ignoring boss attacks by taking damage from other sources
			return true;
		}

        public override void AI()
        {
            if (NPC.target < 0 || NPC.target == 255 || Main.player[NPC.target].dead || !Main.player[NPC.target].active)
            {
                NPC.TargetClosest();
            }

            Player player = Main.player[NPC.target];

            if (player.dead)
            {
                // If the targeted player is dead, flee
                NPC.velocity.Y -= 0.04f;
                // This method makes it so when the boss is in "despawn range" (outside of the screen), it despawns in 10 ticks
                NPC.EncourageDespawn(10);
                return;
            }

            DoFirstStage(player);

        }
        private void DoFirstStage(Player player)
        {
            // Each time the timer is 0, pick a random position a fixed distance away from the player but towards the opposite side
            // The NPC moves directly towards it with fixed speed, while displaying its trajectory as a telegraph

            FirstStageTimer++;
            if (FirstStageTimer > FirstStageTimerMax)
            {
                FirstStageTimer = 0;
            }

            float distance = 200; // Distance in pixels behind the player

            if (FirstStageTimer == 0)
            {
                Vector2 fromPlayer = NPC.Center - player.Center;

                if (Main.netMode != NetmodeID.MultiplayerClient)
                {
                    // Important multiplayer concideration: drastic change in behavior (that is also decided by randomness) like this requires
                    // to be executed on the server (or singleplayer) to keep the boss in sync

                    float angle = fromPlayer.ToRotation();
                    float twelfth = MathHelper.Pi / 6;

                    angle += MathHelper.Pi + Main.rand.NextFloat(-twelfth, twelfth);
                    if (angle > MathHelper.TwoPi)
                    {
                        angle -= MathHelper.TwoPi;
                    }
                    else if (angle < 0)
                    {
                        angle += MathHelper.TwoPi;
                    }

                    Vector2 relativeDestination = angle.ToRotationVector2() * distance;

                    FirstStageDestination = player.Center + relativeDestination;
                    NPC.netUpdate = true;
                }
            }

            // Move along the vector
            Vector2 toDestination = FirstStageDestination - NPC.Center;
            Vector2 toDestinationNormalized = toDestination.SafeNormalize(Vector2.UnitY);
            float speed = Math.Min(distance, toDestination.Length());
            NPC.velocity = toDestinationNormalized * speed / 30;

            if (FirstStageDestination != LastFirstStageDestination)
            {
                // If destination changed
                NPC.TargetClosest(); // Pick the closest player target again

                // "Why is this not in the same code that sets FirstStageDestination?" Because in multiplayer it's ran by the server.
                // The client has to know when the destination changes a different way. Keeping track of the previous ticks' destination is one way
                if (Main.netMode != NetmodeID.Server)
                {
                    // For visuals regarding NPC position, netOffset has to be concidered to make visuals align properly
                    NPC.position += NPC.netOffset;

                    // Draw a line between the NPC and its destination, represented as dusts every 20 pixels
                    Dust.QuickDustLine(NPC.Center + toDestinationNormalized * NPC.width, FirstStageDestination, toDestination.Length() / 20f, Color.Yellow);

                    NPC.position -= NPC.netOffset;
                }
            }
            LastFirstStageDestination = FirstStageDestination;
        }

        public override void FindFrame(int frameHeight) {
			// This NPC animates with a simple "go from start frame to final frame, and loop back to start frame" rule
			// In this case: First stage: 0-1-2-0-1-2, Second stage: 3-4-5-3-4-5, 5 being "total frame count - 1"
			int startFrame = 0;
			int finalFrame = 1;

            int frameSpeed = 5;
			NPC.frameCounter += 0.2f;
			if (NPC.frameCounter > frameSpeed) {
				NPC.frameCounter = 0;
				NPC.frame.Y += frameHeight;

				if (NPC.frame.Y > finalFrame * frameHeight) {
					NPC.frame.Y = startFrame * frameHeight;
				}
			}
		}



    }
}
