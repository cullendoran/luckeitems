﻿using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace luckeitems.Content.Items.Materials.Bar
{
	public class MixedHMetal : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Mixed Hardmode Metals");
            Tooltip.SetDefault("A varity of hardmode metals mixed into one single bar\n"
							 + "Only the fragmented power of all 4 pillars can condense an item this far\n"
                             + "'One wrong fall and this thing will turn into a black hole...'\n");
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
            recipe.AddRecipeGroup("luckeitems:CobaltBarGroup", 25);
            recipe.AddRecipeGroup("luckeitems:MythrilBarGroup", 25);
            recipe.AddRecipeGroup("luckeitems:TitaniumBarGroup", 25);
            recipe.AddIngredient(ItemID.HallowedBar, 25);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 25);
            recipe.AddIngredient(ItemID.ShroomiteBar, 25);
            recipe.AddIngredient(ItemID.SpectreBar, 25);
            recipe.AddIngredient(ItemID.LunarBar, 25);
            recipe.AddTile(TileID.LunarBlockVortex);
            recipe.AddTile(TileID.LunarBlockSolar);
            recipe.AddTile(TileID.LunarBlockNebula);
            recipe.AddTile(TileID.LunarBlockStardust);
            recipe.Register();
        }
	}
}
