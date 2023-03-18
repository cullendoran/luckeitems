using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Common.Players;

namespace luckeitems.Content.Items.Accessories.Emblem.GP
{
	public class GPWarriorEmblem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("GoldenPlatinum Warrior Emblem");
			Tooltip.SetDefault("Increases melee damage by 4%\n"
                             + "'Made from only the finest GoldenPlatinum™!'\n");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<LuckEEmblemPlayer>().GPWarriorEmblem = true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Items.Materials.Bar.GPBar>(5);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}