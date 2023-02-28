using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace luckeitems.Common.Players
{
	public class LuckEPlayer : ModPlayer
	{
		public bool HasSoulOfCorruptionAcc;
        public bool HasSoulOfCrimsonAcc;

        // Always reset the accessory field to its default value here.
        public override void ResetEffects() {
            HasSoulOfCorruptionAcc = false;
            HasSoulOfCrimsonAcc = false;
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
