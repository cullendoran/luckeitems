using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

namespace luckeitems.Content.Items
{
	public class TempItemSprite : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Temp Item Sprite");
            Tooltip.SetDefault("This is a temp item used for temp sprites, DOES NOT DO ANYTHING!.");
		}

		public override void SetDefaults() {
			Item.width = 28; // The item texture's width
			Item.height = 28; // The item texture's height
        }

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }

		// Researching the Example item will give you immediate access to the torch, block, wall and workbench!
	}
}
