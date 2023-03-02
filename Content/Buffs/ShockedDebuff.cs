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

        // TODO: Inconsistent with vanilla, increasing damage AFTER it is randomised, not before. Change to a different hook in the future.
        public override void ModifyHitNPC(NPC npc, NPC target, ref int damage, ref float knockback, ref bool crit)
        {
            if (shockedDebuff)
			{
				
            }
        }
    }
}
