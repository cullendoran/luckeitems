using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;
using luckeitems.Content.Items.Materials.Ore;

namespace luckeitems.Content.Items.Materials.Electricial
{
	public class CircuitBoard : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Circuit Board");
            Tooltip.SetDefault("Circuit Board\n"
                             + "'FUNNY TEXT'\n");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 25; // How many items are needed in order to research duplication of this item in Journey mode. See https://terraria.gamepedia.com/Journey_Mode/Research_list for a list of commonly used research amounts depending on item type.
		}

		public override void SetDefaults() {
			Item.width = 28; // The item texture's width
			Item.height = 28; // The item texture's height

			Item.maxStack = 999; // The item's max stack value
        }

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wire,6);
            recipe.AddIngredient(ItemID.SandBlock, 7);
            recipe.AddIngredient<Silicon>(5);
            recipe.AddRecipeGroup("luckeitems:MythrilBarGroup", 2);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }

		// Researching the Example item will give you immediate access to the torch, block, wall and workbench!
	}
}
