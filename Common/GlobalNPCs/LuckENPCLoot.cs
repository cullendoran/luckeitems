using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using luckeitems.Content.Items.Accessories.Boss.Mech;

namespace luckeitems.Common.GlobalNPCs
{
	public class LuckENPCLoot : GlobalNPC
	{

		public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot) {
			if (npc.type == NPCID.Spazmatism) {
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<SoulOfCorruption>(), 1));
			}

            if (npc.type == NPCID.Retinazer)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<SoulOfCrimson>(), 1));
            }
        }
	}
}
