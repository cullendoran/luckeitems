using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Common.Players;

namespace luckeitems.Content.Items.Accessories.Emblem.PostPlanterra
{
	public class ShroomiteRangerEmblem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Shroomite Ranger Emblem");
			Tooltip.SetDefault("Increases ranged damage by 30%\n"
							 + "Gives Shroomite Armor Bonus\n"
                             + "Also gives +12% move speed and +25% ranged crit chance\n"
                             + "'GMO Free!'\n");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.GetModPlayer<LuckEEmblemPlayer>().ShroomiteRangerEmblem = true;
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