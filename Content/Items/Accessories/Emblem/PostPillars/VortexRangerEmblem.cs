using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Common.Players;

namespace luckeitems.Content.Items.Accessories.Emblem.PostPillars
{
	public class VortexRangerEmblem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Vortex Ranger Emblem");
			Tooltip.SetDefault("Increases ranged damage by 36%\n"
                             + "Gives +27% ranged crit chance, +25% chance not to consume ammo and +10% movement speed\n"
                             + "Also gives Vortex Stealth bonus\n"
                             + "'Blackhole.mp3'\n");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.GetModPlayer<LuckEEmblemPlayer>().VortexRangerEmblem = true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.FragmentVortex, 40);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
        }
    }
}