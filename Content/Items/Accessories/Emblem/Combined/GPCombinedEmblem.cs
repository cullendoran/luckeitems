using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Common.Players;

namespace luckeitems.Content.Items.Accessories.Emblem.Combined
{
	public class GPCombinedEmblem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("GoldenPlatinum Emblem");
            Tooltip.SetDefault("Increases all damage by 4%\n"
                             + "'Made from only the finest GoldenPlatinum™!'\n");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<LuckEEmblemPlayer>().GPCombinedEmblem = true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<GP.GPWarriorEmblem>();
            recipe.AddIngredient<GP.GPRangerEmblem>();
            recipe.AddIngredient<GP.GPSorcererEmblem>();
            recipe.AddIngredient<GP.GPSummonerEmblem>();
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}