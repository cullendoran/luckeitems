using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Common.Players;
using luckeitems.Content.Items.Materials.Electricial;
using luckeitems.Content.Tiles.Crafting;

namespace luckeitems.Content.Items.Accessories.Power.Storage
{
	public class PlatinumBattery : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Platinum Battery");
			Tooltip.SetDefault("Gives +30 max electricity while equiped\n"
							 + "'FUNNY TEXT'\n");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.GetModPlayer<ElectricityResourcePlayer>().electricityResourceMax2 += 30;
			player.GetModPlayer<LuckEPlayer>().isEStorageItem = true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<CopperWire>(5);
            recipe.AddRecipeGroup("luckeitems:PlatinumBarGroup", 13);
            recipe.AddTile<ElectricBench>();
            recipe.Register();
        }
    }
}