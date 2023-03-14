using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Common.Players;
using luckeitems.Content.Items.Materials.Electricial;
using luckeitems.Content.Tiles.Crafting;

namespace luckeitems.Content.Items.Accessories.Power.Storage
{
	public class SimpleBattery : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Simple Battery");
			Tooltip.SetDefault("Gives +10 max electricity while equiped\n"
							 + "'FUNNY TEXT'\n");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 46;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
           player.GetModPlayer<ElectricityResourcePlayer>().electricityResourceMax2 += 10;
			player.GetModPlayer<LuckEPlayer>().isEStorageItem = true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
			recipe.AddIngredient<CopperWire>(3);
            recipe.AddRecipeGroup("luckeitems:CopperBarGroup", 5);
            recipe.AddTile<ElectricBench>();
            recipe.Register();
        }
    }
}