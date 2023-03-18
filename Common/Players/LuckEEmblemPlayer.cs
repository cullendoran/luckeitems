using luckeitems.Content.Items.Accessories.Mega;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace luckeitems.Common.Players
{
    //All emblem player stuff goes here for easy access later as of 3/17
	public class LuckEEmblemPlayer : ModPlayer
	{
        // Emblem Misc Effects
        public bool EvilEmblemDefBoost;
        public bool PureAscensionEmblem;

        // Wood Emblem Values
        public bool WoodWarriorEmblem;
        public bool WoodRangerEmblem;
        public bool WoodSorcererEmblem;
        public bool WoodSummonerEmblem;
        public bool WoodCombinedEmblem;

        // GP Emblem Values
        public bool GPWarriorEmblem;
        public bool GPRangerEmblem;
        public bool GPSorcererEmblem;
        public bool GPSummonerEmblem;
        public bool GPCombinedEmblem;

        // Evil Emblem Values
        public bool EvilWarriorEmblem;
        public bool EvilRangerEmblem;
        public bool EvilSorcererEmblem;
        public bool EvilSummonerEmblem;
        public bool EvilCombinedEmblem;

        // Planterra Emblem Values
        public bool TurtleWarriorEmblem;
        public bool ShroomiteRangerEmblem;
        public bool SpectreSorcererEmblem;
        public bool SpookySummonerEmblem;
        public bool PlanterraCombinedEmblem;

        public override void ResetEffects() 
        {
            // Emblem Misc Reset Effects
            EvilEmblemDefBoost = false;
            PureAscensionEmblem = false;

            // Wood Emblem Reset Effects
            WoodWarriorEmblem = false;
            WoodRangerEmblem = false;
            WoodSorcererEmblem = false;
            WoodSummonerEmblem = false;
            WoodCombinedEmblem = false;

            // GP Emblem Reset Effects
            GPWarriorEmblem = false;
            GPRangerEmblem = false;
            GPSorcererEmblem = false;
            GPSummonerEmblem = false;
            GPCombinedEmblem = false;

            // Evil Emblem Reset Effects
            EvilWarriorEmblem = false;
            EvilRangerEmblem = false;
            EvilSorcererEmblem = false;
            EvilSummonerEmblem = false;
            EvilCombinedEmblem = false;

            // Planterra Emblem Reset Effects
            TurtleWarriorEmblem = false;
            ShroomiteRangerEmblem = false;
            SpectreSorcererEmblem = false;
            SpookySummonerEmblem = false;
            PlanterraCombinedEmblem = false;
        }

        public override void UpdateEquips()
        {
            if (PureAscensionEmblem)
            {
                Player.GetModPlayer<LuckEEmblemPlayer>().WoodCombinedEmblem = true;
                Player.GetModPlayer<LuckEEmblemPlayer>().GPCombinedEmblem = true;
                Player.GetModPlayer<LuckEEmblemPlayer>().EvilCombinedEmblem = true;
                Player.GetModPlayer<LuckEEmblemPlayer>().PlanterraCombinedEmblem = true;
            }
            // Misc Emblem Effect Update Equips
            if (EvilEmblemDefBoost)
            {
                if (Player.ZoneCorrupt || Player.ZoneCrimson)
                {
                    Player.statDefense += 7;
                }
            }

            // Wood Emblem Update Equips
            if (WoodCombinedEmblem)
            {
                Player.GetModPlayer<LuckEEmblemPlayer>().WoodWarriorEmblem = true;
                Player.GetModPlayer<LuckEEmblemPlayer>().WoodRangerEmblem = true;
                Player.GetModPlayer<LuckEEmblemPlayer>().WoodSorcererEmblem = true;
                Player.GetModPlayer<LuckEEmblemPlayer>().WoodSummonerEmblem = true;
            }
            if (WoodWarriorEmblem)
            {
                Player.GetDamage(DamageClass.Melee).Flat += 2f;
            }
            if (WoodRangerEmblem)
            {
                Player.GetDamage(DamageClass.Ranged).Flat += 2f;
            }
            if (WoodSorcererEmblem)
            {
                Player.GetDamage(DamageClass.Magic).Flat += 2f;
            }
            if (WoodSummonerEmblem)
            {
                Player.GetDamage(DamageClass.Summon).Flat += 2f;
            }

            // GP Emblem Update Equips
            if (GPCombinedEmblem)
            {
                Player.GetModPlayer<LuckEEmblemPlayer>().GPWarriorEmblem = true;
                Player.GetModPlayer<LuckEEmblemPlayer>().GPRangerEmblem = true;
                Player.GetModPlayer<LuckEEmblemPlayer>().GPSorcererEmblem = true;
                Player.GetModPlayer<LuckEEmblemPlayer>().GPSummonerEmblem = true;
            }
            if (GPWarriorEmblem)
            {
                Player.GetDamage(DamageClass.Melee) += 0.04f;
            }
            if (GPRangerEmblem)
            {
                Player.GetDamage(DamageClass.Ranged) += 0.04f;
            }
            if (GPSorcererEmblem)
            {
                Player.GetDamage(DamageClass.Magic) += 0.04f;
            }
            if (GPSummonerEmblem)
            {
                Player.GetDamage(DamageClass.Summon) += 0.04f;
            }

            // Evil Emblem Update Equips
            if (EvilCombinedEmblem)
            {
                Player.GetModPlayer<LuckEEmblemPlayer>().EvilWarriorEmblem = true;
                Player.GetModPlayer<LuckEEmblemPlayer>().EvilRangerEmblem = true;
                Player.GetModPlayer<LuckEEmblemPlayer>().EvilSorcererEmblem = true;
                Player.GetModPlayer<LuckEEmblemPlayer>().EvilSummonerEmblem = true;
                Player.GetModPlayer<LuckEEmblemPlayer>().EvilEmblemDefBoost = true;
            }
            if (EvilWarriorEmblem)
            {
                Player.GetDamage(DamageClass.Melee) += 0.07f;
                Player.GetModPlayer<LuckEEmblemPlayer>().EvilEmblemDefBoost = true;
            }
            if (EvilRangerEmblem)
            {
                Player.GetDamage(DamageClass.Ranged) += 0.07f;
                Player.GetModPlayer<LuckEEmblemPlayer>().EvilEmblemDefBoost = true;
            }
            if (EvilSorcererEmblem)
            {
                Player.GetDamage(DamageClass.Magic) += 0.07f;
                Player.GetModPlayer<LuckEEmblemPlayer>().EvilEmblemDefBoost = true;
            }
            if (EvilSummonerEmblem)
            {
                Player.GetDamage(DamageClass.Summon) += 0.07f;
                Player.GetModPlayer<LuckEEmblemPlayer>().EvilEmblemDefBoost = true;
            }

            // Planterra Emblem Update Equips
            if (PlanterraCombinedEmblem)
            {
                Player.GetModPlayer<LuckEEmblemPlayer>().TurtleWarriorEmblem = true;
                Player.GetModPlayer<LuckEEmblemPlayer>().ShroomiteRangerEmblem = true;
                Player.GetModPlayer<LuckEEmblemPlayer>().SpectreSorcererEmblem = true;
                Player.GetModPlayer<LuckEEmblemPlayer>().SpookySummonerEmblem = true;
            }
            if (TurtleWarriorEmblem)
            {
                Player.GetDamage(DamageClass.Melee) += 0.30f;
                Player.GetCritChance(DamageClass.Melee) += 0.12f;
                Player.endurance += 0.15f;
                Player.turtleThorns = true;
            }
            if (ShroomiteRangerEmblem)
            {
                Player.GetDamage(DamageClass.Ranged) += 0.30f;
                Player.shroomiteStealth = true;
                Player.moveSpeed += 0.12f;
                Player.GetCritChance(DamageClass.Ranged) += 0.25f;
            }
            if (SpectreSorcererEmblem)
            {
                Player.GetDamage(DamageClass.Magic) += 0.30f;
                Player.manaCost -= 0.13f;
                Player.statManaMax2 += 60;
            }
            if (SpookySummonerEmblem)
            {
                Player.GetDamage(DamageClass.Summon) += 0.30f;
                Player.moveSpeed += 0.20f;
                Player.maxMinions += 4;
            }
        }
    }
}
