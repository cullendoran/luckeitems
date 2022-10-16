﻿using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace luckeitems.Content.Items.Materials.Bar
{
	public class ReinforcedGPBar : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("ReinforcedGP Bar");
            Tooltip.SetDefault("ReinforcedGP Liquid cooled and shaped into a bar.\n"
                             + "'Watch out everyone, the potato is hot!'\n");
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
            recipe.AddIngredient<Items.Materials.Bucket.ReinforcedGPBucket>();
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.AddCondition(Recipe.Condition.NearWater);
            recipe.Register();
        }
	}
}
