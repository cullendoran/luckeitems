using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;
using luckeitems.Content.Tiles.Crafting;

namespace luckeitems.Content.Items.Materials.Electricial
{
	public class Motor : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Motor");
            Tooltip.SetDefault("Motor\n"
                             + "'FUNNY TEXT'\n");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 25; // How many items are needed in order to research duplication of this item in Journey mode. See https://terraria.gamepedia.com/Journey_Mode/Research_list for a list of commonly used research amounts depending on item type.
		}

		public override void SetDefaults() {
			Item.width = 27; // The item texture's width
			Item.height = 16; // The item texture's height

			Item.maxStack = 999; // The item's max stack value
        }

		public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<CopperWire>(18);
            recipe.AddRecipeGroup("luckeitems:TungstenBarGroup", 3);
            recipe.AddRecipeGroup("luckeitems:IronBarGroup", 8);
            recipe.AddTile<ElectricBench>();
            recipe.Register();
        }

		// Researching the Example item will give you immediate access to the torch, block, wall and workbench!
	}
}
