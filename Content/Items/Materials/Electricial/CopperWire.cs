using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

namespace luckeitems.Content.Items.Materials.Electricial
{
	public class CopperWire : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Copper Wire");
            Tooltip.SetDefault("Copper Wire\n"
                             + "'FUNNY TEXT'\n");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100; // How many items are needed in order to research duplication of this item in Journey mode. See https://terraria.gamepedia.com/Journey_Mode/Research_list for a list of commonly used research amounts depending on item type.
		}

		public override void SetDefaults() {
			Item.width = 28; // The item texture's width
			Item.height = 28; // The item texture's height

			Item.maxStack = 999; // The item's max stack value
        }

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddRecipeGroup("luckeitems:CopperBarGroup", 3);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }

		// Researching the Example item will give you immediate access to the torch, block, wall and workbench!
	}
}
