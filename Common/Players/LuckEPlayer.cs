using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace luckeitems.Common.Players
{
	public class LuckEPlayer : ModPlayer
	{
		public bool HasSoulOfCorruptionAcc;
        public bool HasSoulOfCrimsonAcc;
        public bool showElectricalPower;
        public bool sBatteryAcc;
        public bool powerMeterAcc;

        // Always reset the accessory field to its default value here.
        public override void ResetEffects() {
            HasSoulOfCorruptionAcc = false;
            HasSoulOfCrimsonAcc = false;
            showElectricalPower = false;
            sBatteryAcc = false;
            powerMeterAcc = false;
        }

        public override void UpdateEquips()
        {
            if (powerMeterAcc)
            {
                showElectricalPower = true;
            }

            if (sBatteryAcc)
            {
                Main.LocalPlayer.GetModPlayer<ElectricityResourcePlayer>().electricityResourceMax2 += 20;
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
    }
}
