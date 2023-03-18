using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Common.Players;

namespace luckeitems.Content.Items.Accessories.Emblem.PostPlanterra
{
	public class SpectreSorcererEmblem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Spectre Sorcerer Emblem");
			Tooltip.SetDefault("Increases magic damage by 30%\n"
                             + "Gives +60 mana and -13% mana cost\n"
                             + "'Boo! Im a ghost now!'\n"
                             );

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<LuckEEmblemPlayer>().SpectreSorcererEmblem = true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SpectreBar, 20);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}