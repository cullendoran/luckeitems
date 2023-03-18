using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Common.Players;

namespace luckeitems.Content.Items.Accessories.Emblem.Combined
{
	public class PlanterraCombinedEmblem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Planterra Emblem");
			Tooltip.SetDefault("Gives effects of other planterra emblems\n"
                             + "'Even a soul infused plant can't stop your wrath.'\n");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<LuckEEmblemPlayer>().PlanterraCombinedEmblem = true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<PostPlanterra.TurtleWarriorEmblem>();
            recipe.AddIngredient<PostPlanterra.ShroomiteRangerEmblem>();
            recipe.AddIngredient<PostPlanterra.SpectreSorcererEmblem>();
            recipe.AddIngredient<PostPlanterra.SpookySummonerEmblem>();
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}