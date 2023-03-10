using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Common.Players;
using System.Collections.Generic;
using luckeitems.Content.Items.Materials.Ore;
using luckeitems.Content.Items.Materials.Electricial;

namespace luckeitems.Content.Items.Accessories.Power.Generators
{
	public class WindGen : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Wind Generator");
			Tooltip.SetDefault("Produces electricity depending on wind speed\n"
							 + "'FUNNY TEXT'\n");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<LuckEPlayer>().isEGeneratorItem = true;
            player.GetModPlayer<LuckEPlayer>().windGenerator = true;
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips.Insert(index: 4, new TooltipLine(Mod, "Wind Speed Effect", $"[c/006d00:{Main.LocalPlayer.GetModPlayer<ElectricityResourcePlayer>().windSpeedFinal / 8}] Effectiveness"));
            tooltips.Insert(index: 4, new TooltipLine(Mod, "Wind Speed", $"[c/006d00:{Main.LocalPlayer.GetModPlayer<ElectricityResourcePlayer>().windSpeedFinal}] MPH"));
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<MetalBlade>(3);
            recipe.AddIngredient<Motor>(1);
            recipe.AddIngredient<CopperWire>(9);
            recipe.AddRecipeGroup("luckeitems:PlatinumBarGroup", 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}