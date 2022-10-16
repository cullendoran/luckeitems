using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

namespace luckeitems.Content.Items.Materials.Bucket
{
	public class ReinforcedGPBucket : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Reinforced GP Bucket");
            Tooltip.SetDefault("GoldenPlatinum & Titanium melted together into a liquid state, needs to be shaped into a bar and cooled down.\n"
                             + "'I am TITANIUMMMMMM!.'\n");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 25; // How many items are needed in order to research duplication of this item in Journey mode. See https://terraria.gamepedia.com/Journey_Mode/Research_list for a list of commonly used research amounts depending on item type.
		}

		public override void SetDefaults() {
			Item.width = 24; // The item texture's width
			Item.height = 22; // The item texture's height

			Item.maxStack = 999; // The item's max stack value
            Item.value = Item.sellPrice(gold: 1);
        }

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Items.Materials.Bucket.GPBucket>(1);
            recipe.AddRecipeGroup("luckeitems:TitaniumOreGroup", 10);
            recipe.AddTile<Tiles.Crafting.Melter>();
            recipe.Register();
        }

		// Researching the Example item will give you immediate access to the torch, block, wall and workbench!
	}
}
