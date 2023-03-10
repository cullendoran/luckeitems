using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace luckeitems.Common.Players
{
	public class LuckEPlayer : ModPlayer
	{
		public bool HasSoulOfCorruptionAcc;
        public bool HasSoulOfCrimsonAcc;
        public bool showElectricalPower;
        public bool powerMeterAcc;
        public bool isEStorageItem;
        public bool isEStorageItemEquiped;
        public bool gelGenerator;
        public bool isEGeneratorItemEquiped;
        public bool isEGeneratorItem;
        public bool windGenerator;
        public bool autoAIHealer;
        public int lifeCounter;

        // Always reset the accessory field to its default value here.
        public override void ResetEffects() {
            HasSoulOfCorruptionAcc = false;
            HasSoulOfCrimsonAcc = false;
            showElectricalPower = false;
            powerMeterAcc = false;
            isEStorageItemEquiped = false;
            isEStorageItem = false;
            isEGeneratorItemEquiped = false;
            gelGenerator = false;
            isEGeneratorItem = false;
            windGenerator = false;
            autoAIHealer = false;
        }

        public override void UpdateEquips()
        {
            if (isEStorageItem)
            {
                isEStorageItemEquiped = true;
            }
            if (isEGeneratorItem)
            {
                isEGeneratorItemEquiped = true;
            }
            if (powerMeterAcc)
            {
                showElectricalPower = true;
            }
        }

        public override void OnHitNPC(Item item, NPC target, int damage, float knockback, bool crit)
        {
            if (HasSoulOfCorruptionAcc)
            {
                target.AddBuff(BuffID.CursedInferno, 600);
            }
            if (HasSoulOfCrimsonAcc)
            {
                target.AddBuff(BuffID.Ichor, 600);
            }
            else
            {
                return;
            }
        }

        public override void OnHitNPCWithProj(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
            if (HasSoulOfCorruptionAcc)
            {
                target.AddBuff(BuffID.CursedInferno, 600);
            }
            if (HasSoulOfCrimsonAcc)
            {
                target.AddBuff(BuffID.Ichor, 600);
            }
            else
            {
                return;
            }
        }

        public override void PostHurt(bool pvp, bool quiet, double damage, int hitDirection, bool crit, int cooldownCounter)
        {
            if (autoAIHealer)
            {
                if (Player.QuickHeal_GetItemToUse() != null)
                {
                    if (Player.statLife < Player.statLifeMax2)
                    {
                        lifeCounter = Player.statLifeMax2 - Player.statLife;
                        if (lifeCounter <= Player.QuickHeal_GetItemToUse().healLife && !Player.HasBuff(BuffID.PotionSickness))
                        {
                            Player.QuickHeal();
                        }
                    }
                }
            }
        }
    }
}
