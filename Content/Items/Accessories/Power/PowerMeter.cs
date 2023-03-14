using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Common.Players;
using luckeitems.Content.Tiles.Crafting;

namespace luckeitems.Content.Items.Accessories.Power
{
	public class PowerMeter : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Power Meter");
            Tooltip.SetDefault("Favorite this item to show your current charge\n"
                             + "'It's over 9000!'\n");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 24;
			Item.height = 38;
		}
        public override void UpdateInventory(Player player)
        {
            if (Item.favorited)
            {
                player.GetModPlayer<LuckEPlayer>().powerMeterAcc = true;
            }
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddRecipeGroup("luckeitems:IronBarGroup", 6);
            recipe.AddTile<ElectricBench>();
            recipe.Register();
        }
    }
}