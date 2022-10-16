using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace luckeitems.Content.Items.Materials.Ore
{
	public class SlimedOre : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Slimed Ore");
            Tooltip.SetDefault("It's a mixture of luminite and slime.\n"
                             + "'It's still moving...'\n");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
			ItemID.Sets.SortingPriorityMaterials[Item.type] = 58;
		}

		public override void SetDefaults() {
			Item.maxStack = 999;
			Item.width = 12;
			Item.height = 12;
            Item.value = Item.sellPrice(gold: 1);
        }
	}
}