using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace luckeitems.Content.Items.Placeable.Crafting
{
	public class ElectricBench : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Electric Bench");
			Tooltip.SetDefault("A electricians best friend.\n"
                             + "'WARNING: Electric Hazard!'");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Crafting.ElectricBench>());
			Item.value = 0;
			Item.maxStack = 99;
			Item.width = 38;
			Item.height = 48;
		}

		public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.WoodenTable);
            recipe.AddRecipeGroup("luckeitems:IronBarGroup", 8);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
	}
}
