using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Common.Players;

namespace luckeitems.Content.Items.Accessories.Emblem.Combined
{
	public class LunarCombinedEmblem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Lunar Emblem");
			Tooltip.SetDefault("Gives effects of other lunar emblems\n"
							 + "'The moonlord is now but just a mere spec...'\n");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<LuckEEmblemPlayer>().LunarCombinedEmblem = true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<PostPillars.SolarWarriorEmblem>();
            recipe.AddIngredient<PostPillars.VortexRangerEmblem>();
            recipe.AddIngredient<PostPillars.NebulaSorcererEmblem>();
            recipe.AddIngredient<PostPillars.StardustSummonerEmblem>();
            recipe.AddIngredient(ItemID.LunarBar, 25);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
        }
    }
}