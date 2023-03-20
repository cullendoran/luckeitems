using luckeitems.Common.Players;
using System.Collections.Generic;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace luckeitems.Content.Items.Accessories.Mega
{
	public class PureAscensionEmblem : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Ascension Emblem");
            Tooltip.SetDefault("Gives the effects of all emblems\n" + "'Godlike!'\n");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips.Insert(index: 3, new TooltipLine(Mod, "Early Testing Warning", $"[c/ff0000:-Early Testing-]"));
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<LuckEEmblemPlayer>().PureAscensionEmblem = true;
        }
		
		public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Materials.Bar.AscendedBar>(1);
            recipe.AddIngredient<Emblem.Combined.WoodCombinedEmblem>(1);
            recipe.AddIngredient<Emblem.Combined.GPCombinedEmblem> (1);
            recipe.AddIngredient<Emblem.Combined.EvilCombinedEmblem> (1);
            recipe.AddIngredient<Emblem.Combined.PlanterraCombinedEmblem>(1);
			recipe.AddIngredient<Emblem.Combined.LunarCombinedEmblem>(1);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
        }
    }
}