using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using luckeitems.Content.NPCs.LuckE;
using luckeitems.Content.Items.Materials.Bar;

namespace luckeitems.Content.Items.Consumables
{
	public class ShinyCoin : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Shiny Coin");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 3;
			ItemID.Sets.SortingPriorityBossSpawns[Type] = 12; // This helps sort inventory know that this is a boss summoning Item.

			// If this would be for a vanilla boss that has no summon item, you would have to include this line here:
			// NPCID.Sets.MPAllowedEnemies[NPCID.Plantera] = true;

			// Otherwise the UseItem code to spawn it will not work in multiplayer
		}
		public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
			TooltipLine line = new TooltipLine(Mod, "ShinyCoinL1", "You think you can defeat me?");
			line.OverrideColor = new Color(255, 87, 51);
			tooltips.Add(line);
			TooltipLine line2 = new TooltipLine(Mod, "ShinyCoinL2", "We shall see...");
			line2.OverrideColor = new Color(255, 87, 51);
			tooltips.Add(line2);
			TooltipLine line3 = new TooltipLine(Mod, "ShinyCoinL3", "-Creator Item-");
			line3.OverrideColor = new Color(Main.DiscoR, Main.DiscoG, Main.DiscoB);
			tooltips.Add(line3);

        }


        public override void SetDefaults() {
			Item.width = 20;
			Item.height = 30;
			Item.maxStack = 20;
			Item.value = 0;
			Item.useAnimation = 30;
			Item.useTime = 30;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.consumable = true;
		}

		public override bool CanUseItem(Player player) {
			// If you decide to use the below UseItem code, you have to include !NPC.AnyNPCs(id), as this is also the check the server does when receiving MessageID.SpawnBoss.
			// If you want more constraints for the summon item, combine them as boolean expressions:
			//    return !Main.dayTime && !NPC.AnyNPCs(ModContent.NPCType<MinionBossBody>()); would mean "not daytime and no MinionBossBody currently alive"
			return !NPC.AnyNPCs(ModContent.NPCType<LuckE>());
		}

		public override bool? UseItem(Player player) {
			if (player.whoAmI == Main.myPlayer) {
                // If the player using the item is the client
                // (explicitely excluded serverside here)
				SoundEngine.PlaySound(SoundID.Coins, player.position);

				int type = ModContent.NPCType<LuckE>();

				if (Main.netMode != NetmodeID.MultiplayerClient) {
					// If the player is not in multiplayer, spawn directly
					NPC.SpawnOnPlayer(player.whoAmI, type);
				}
				else {
					// If the player is in multiplayer, request a spawn
					// This will only work if NPCID.Sets.MPAllowedEnemies[type] is true, which we set in MinionBossBody
					NetMessage.SendData(MessageID.SpawnBoss, number: player.whoAmI, number2: type);
				}
			}

			return true;
		}

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<GPBar>(20);
            recipe.AddIngredient(ItemID.FragmentSolar, 5);
            recipe.AddIngredient(ItemID.FragmentVortex, 5);
            recipe.AddIngredient(ItemID.FragmentNebula, 5);
            recipe.AddIngredient(ItemID.FragmentStardust, 5);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
        }
        // Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
    }
}