using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;
using luckeitems.Content.Tiles.Crafting;

namespace luckeitems.Content.Items.Materials.Electricial
{
	public class HallowedWire : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Hallowed Wire");
            Tooltip.SetDefault("Hallowed Wire\n"
                             + "'FUNNY TEXT'\n");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99; // How many items are needed in order to research duplication of this item in Journey mode. See https://terraria.gamepedia.com/Journey_Mode/Research_list for a list of commonly used research amounts depending on item type.
		}

		public override void SetDefaults() {
			Item.width = 28; // The item texture's width
			Item.height = 28; // The item texture's height

			Item.maxStack = 999; // The item's max stack value
        }

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes() {
            Recipe recipe = CreateRecipe(3);
            recipe.AddIngredient<CobaltWire>(3);
            recipe.AddIngredient<TitaniumWire>(3);
            recipe.AddIngredient(ItemID.HallowedBar, 3);
            recipe.AddTile<ElectricBench>();
            recipe.Register();
        }

		// Researching the Example item will give you immediate access to the torch, block, wall and workbench!
	}
}
