using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Common.Players;

namespace luckeitems.Content.Items.Accessories.Emblem.Combined
{
	public class EvilCombinedEmblem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Evil Emblem");
            Tooltip.SetDefault("Increases all damage by 7%\n" + "Also gives +7 defense while in the corruption/crimson\n" + "'Gru would be proud.'\n");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<LuckEEmblemPlayer>().EvilCombinedEmblem = true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Evil.EvilWarriorEmblem>();
            recipe.AddIngredient<Evil.EvilRangerEmblem>();
            recipe.AddIngredient<Evil.EvilSorcererEmblem>();
            recipe.AddIngredient<Evil.EvilSummonerEmblem>();
            recipe.AddTile(TileID.DemonAltar);
            recipe.Register();
        }
    }
}