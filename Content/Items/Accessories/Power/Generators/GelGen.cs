using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Common.Players;
using System.Collections.Generic;
using luckeitems.Content.Items.Materials.Bar;
using luckeitems.Content.Items.Materials.Electricial;

namespace luckeitems.Content.Items.Accessories.Power.Generators
{
	public class GelGen : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Gel Generator");
			Tooltip.SetDefault("Consumes gel to produce electricity\n"
							 + "'FUNNY TEXT'\n");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 46;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.GetModPlayer<LuckEPlayer>().gelGenerator = true;
            player.GetModPlayer<LuckEPlayer>().isEGeneratorItem = true;
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
			if (Main.LocalPlayer.GetModPlayer<ElectricityResourcePlayer>().gelLeftTimer > 0)
			{
                tooltips.Insert(index: 4, new TooltipLine(Mod, "Gel Left Timer Running", $"[c/006d00:{Main.LocalPlayer.GetModPlayer<ElectricityResourcePlayer>().gelLeftTimer}]"));
            }
			if (Main.LocalPlayer.GetModPlayer<ElectricityResourcePlayer>().gelLeftTimer == 0)
			{
                tooltips.Insert(index: 4, new TooltipLine(Mod, "Gel Left Timer Stopped", $"[c/ff0000:{Main.LocalPlayer.GetModPlayer<ElectricityResourcePlayer>().gelLeftTimer}]"));
            }
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Motor>(3);
            recipe.AddIngredient<CopperWire>(9);
            recipe.AddIngredient<GPBar>(5);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}