﻿using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Common.Players;

namespace luckeitems.Content.Items.Accessories.Emblem.Combined
{
	public class WoodCombinedEmblem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Wooden Emblem");
			Tooltip.SetDefault("Increases all damage by 2\n"
							 + "'Your the most desprate person I've seen.'\n");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<LuckEEmblemPlayer>().WoodCombinedEmblem = true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Wood.WoodWarriorEmblem>();
            recipe.AddIngredient<Wood.WoodRangerEmblem>();
            recipe.AddIngredient<Wood.WoodSorcererEmblem>();
            recipe.AddIngredient<Wood.WoodSummonerEmblem>();
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}