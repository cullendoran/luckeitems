﻿using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Common.Players;

namespace luckeitems.Content.Items.Accessories.Emblem.Wood
{
	public class WoodSorcererEmblem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Wooden Sorcerer Emblem");
			Tooltip.SetDefault("Increases magic damage by 2\n"
							 + "'You really are desperate aren't you?'\n");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<LuckEEmblemPlayer>().WoodSorcererEmblem = true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}