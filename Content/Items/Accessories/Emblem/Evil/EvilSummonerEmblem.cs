﻿using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Common.Players;

namespace luckeitems.Content.Items.Accessories.Emblem.Evil
{
	public class EvilSummonerEmblem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Evil Summoner Emblem");
			Tooltip.SetDefault("Increases summon damage by 7%\n" + "Also gives +7 defense while in the corruption/crimson\n" + "'It isn't this easy being evil!'\n");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<LuckEEmblemPlayer>().EvilSummonerEmblem = true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddRecipeGroup("luckeitems:EvilBarGroup", 15);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}