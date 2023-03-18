using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace luckeitems.Content.Items.Materials.Bar
{
	public class AscendedBar : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Ascended Bar");
            Tooltip.SetDefault("A bar that has reached Ascension.\n"
                             + "'Reach for the stars!'\n");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 25;
			ItemID.Sets.SortingPriorityMaterials[Item.type] = 59; // Influences the inventory sort order. 59 is PlatinumBar, higher is more valuable.
		}

		public override void SetDefaults() {
			Item.width = 20;
			Item.height = 20;
			Item.maxStack = 99;
            Item.value = Item.sellPrice(gold: 1);
        }
		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Ore.SlimedOre>(5);
            recipe.AddIngredient<MixedPHMetal>();
            recipe.AddIngredient<MixedHMetal>();
            recipe.AddTile(TileID.LunarCraftingStation);
			recipe.AddCondition(Recipe.Condition.InSkyHeight);
            recipe.AddCondition(Recipe.Condition.TimeNight);
            recipe.Register();
        }
	}
}
