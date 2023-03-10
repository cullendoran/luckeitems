using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace luckeitems.Content.Items.Materials.Ore
{
	public class SlimedOre : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Slimeinite");
            Tooltip.SetDefault("It's a mixture of luminite and slime.\n"
                             + "'DISGUSTING!'\n");
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