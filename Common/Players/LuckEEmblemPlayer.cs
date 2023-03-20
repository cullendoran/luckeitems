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

        // Lunar Emblem Values
        public bool SolarWarriorEmblem;
        public bool VortexRangerEmblem;
        public bool NebulaSorcererEmblem;
        public bool StardustSummonerEmblem;
        public bool LunarCombinedEmblem;

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

            // Lunar Emblem Reset Effects
            SolarWarriorEmblem = false;
            VortexRangerEmblem = false;
            NebulaSorcererEmblem = false;
            StardustSummonerEmblem = false;
            LunarCombinedEmblem = false;

        }

        public override void UpdateEquips()
        {

            // Misc Emblem Effect Update Equips
            if (PureAscensionEmblem)
            {
                Player.GetModPlayer<LuckEEmblemPlayer>().WoodCombinedEmblem = true;
                Player.GetModPlayer<LuckEEmblemPlayer>().GPCombinedEmblem = true;
                Player.GetModPlayer<LuckEEmblemPlayer>().EvilCombinedEmblem = true;
                Player.GetModPlayer<LuckEEmblemPlayer>().PlanterraCombinedEmblem = true;
                Player.GetModPlayer<LuckEEmblemPlayer>().LunarCombinedEmblem = true;
            }

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
                Player.GetDamage(DamageClass.Melee) += 0.14f;
                Player.GetCritChance(DamageClass.Melee) += 0.12f;
                Player.endurance += 0.15f;
                Player.turtleThorns = true;
            }
            if (ShroomiteRangerEmblem)
            {
                Player.GetDamage(DamageClass.Ranged) += 0.13f;
                Player.shroomiteStealth = true;
                Player.moveSpeed += 0.12f;
                Player.GetCritChance(DamageClass.Ranged) += 0.25f;
                Player.ammoCost80 = true;
            }
            if (SpectreSorcererEmblem)
            {
                Player.GetDamage(DamageClass.Magic) += 0.25f;
                Player.GetCritChance(DamageClass.Magic) += 0.17f;
                Player.manaCost -= 0.13f;
                Player.statManaMax2 += 60;
            }
            if (SpookySummonerEmblem)
            {
                Player.GetDamage(DamageClass.Summon) += 0.58f;
                Player.moveSpeed += 0.20f;
                Player.maxMinions += 4;
            }

            // Lunar Emblem Update Equips
            if (LunarCombinedEmblem)
            {
                Player.GetModPlayer<LuckEEmblemPlayer>().SolarWarriorEmblem = true;
                Player.GetModPlayer<LuckEEmblemPlayer>().VortexRangerEmblem = true;
                Player.GetModPlayer<LuckEEmblemPlayer>().NebulaSorcererEmblem = true;
                Player.GetModPlayer<LuckEEmblemPlayer>().StardustSummonerEmblem = true;
            }
            if (SolarWarriorEmblem)
            {
                Player.GetDamage(DamageClass.Melee) += 0.29f;
                Player.GetCritChance(DamageClass.Melee) += 0.26f;
                Player.GetAttackSpeed(DamageClass.Melee) += 0.15f;
                Player.moveSpeed += 0.15f;
                Player.lifeRegen += 3;
            }
            if (VortexRangerEmblem)
            {
                Player.GetDamage(DamageClass.Ranged) += 0.36f;
                Player.vortexStealthActive = true;
                Player.moveSpeed += 0.10f;
                Player.GetCritChance(DamageClass.Ranged) += 0.27f;
                Player.ammoCost75 = true;
            }
            if (NebulaSorcererEmblem)
            {
                Player.GetDamage(DamageClass.Magic) += 0.26f;
                Player.GetCritChance(DamageClass.Magic) += 0.16f;
                Player.manaCost -= 0.15f;
                Player.statManaMax2 += 60;
                Player.moveSpeed += 0.10f;
                Player.setNebula = true;
            }
            if (StardustSummonerEmblem)
            {
                Player.GetDamage(DamageClass.Summon) += 0.66f;
                Player.maxMinions += 5;
                Player.whipRangeMultiplier += 0.30f;
                Player.maxTurrets += 1;
                Player.setStardust = true;

            }
        }
    }
}
