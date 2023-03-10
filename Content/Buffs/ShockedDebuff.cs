using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace luckeitems.Content.Buffs
{
	public class ShockedDebuff : ModBuff
	{
		public override void SetStaticDefaults() {
		}

		public override void Update(NPC npc, ref int buffIndex) {
			npc.GetGlobalNPC<ShockedDebuffNPC>().shockedDebuff = true;
		}
	}

	public class ShockedDebuffNPC : GlobalNPC
	{
		// This is required to store information on entities that isn't shared between them.
		public override bool InstancePerEntity => true;

        public bool shockedDebuff;

		public override void ResetEffects(NPC npc) {
			shockedDebuff = false;
		}

        public override void ModifyHitByItem(NPC npc, Player player, Item item, ref int damage, ref float knockback, ref bool crit)
        {
            if (shockedDebuff)
            {
                Dust.NewDust(npc.Center, npc.width, npc.height + 4, DustID.SparksMech, 0, 0, 255, Color.LightCyan);
                npc.life -= 5;
            }
        }
        public override void ModifyHitByProjectile(NPC npc, Projectile projectile, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            if (shockedDebuff)
            {
                Dust.NewDust(npc.Center, npc.width, npc.height, DustID.SparksMech, 0, 0, 0, Color.LightCyan);
                npc.life -= 5;
            }
        }
    }
}
