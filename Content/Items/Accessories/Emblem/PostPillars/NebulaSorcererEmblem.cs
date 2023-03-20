using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Common.Players;

namespace luckeitems.Content.Items.Accessories.Emblem.PostPillars
{
	public class NebulaSorcererEmblem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Nebula Sorcerer Emblem");
			Tooltip.SetDefault("Increases magic damage by 26%\n"
                             + "Gives +16% magic crit chance, +10% movement speed, +60 mana, and -15% mana cost\n"
                             + "Also gives Nebula Booster bonus\n"
                             + "'It's Nebby!'\n");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.GetModPlayer<LuckEEmblemPlayer>().NebulaSorcererEmblem = true;
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