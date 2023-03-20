using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Common.Players;

namespace luckeitems.Content.Items.Accessories.Emblem.PostPillars
{
	public class StardustSummonerEmblem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Stardust Summoner Emblem");
			Tooltip.SetDefault("Increases summon damage by 66%\n"
                             + "Gives +5 max minions, +30% whip range, and +1 max turrets\n"
                             + "Also gives Stardust Minion bonus\n"
                             + "'The world is yours to command!'\n");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.GetModPlayer<LuckEEmblemPlayer>().StardustSummonerEmblem = true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.FragmentNebula, 40);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
        }
    }
}