using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Common.Players;

namespace luckeitems.Content.Items.Accessories.Power
{
	public class PowerMeter : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Power Meter");
            Tooltip.SetDefault("Shows your current charge\n"
                             + "'It's over 9000!'\n");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 24;
			Item.height = 38;
			Item.accessory = true;
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
            recipe.AddIngredient(ItemID.IronBar, 6);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}