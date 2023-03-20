using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Common.Players;

namespace luckeitems.Content.Items.Accessories.Emblem.PostPillars
{
	public class SolarWarriorEmblem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Solar Warrior Emblem");
			Tooltip.SetDefault("Increases melee damage by 29%\n"
                             + "Gives +26% melee crit chance, +3 life regen and +15% movement and melee speed\n"
                             + "'IMA FIRING MY LAZER!'\n");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.GetModPlayer<LuckEEmblemPlayer>().SolarWarriorEmblem = true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.FragmentSolar, 40);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
        }
    }
}