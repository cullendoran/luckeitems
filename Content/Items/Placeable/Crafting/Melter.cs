using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace luckeitems.Content.Items.Placeable.Crafting
{
	public class Melter : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Melter");
			Tooltip.SetDefault("Used for melting multiple things into one.\n"
                             + "'It's a hot topic!'");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Crafting.Melter>());
			Item.value = 0;
			Item.maxStack = 99;
			Item.width = 38;
			Item.height = 24;
		}

		public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddIngredient(ItemID.IronBar, 8);
            recipe.AddIngredient(ItemID.LavaBucket, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
	}
}
