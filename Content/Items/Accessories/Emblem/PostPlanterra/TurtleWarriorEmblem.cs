using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Common.Players;

namespace luckeitems.Content.Items.Accessories.Emblem.PostPlanterra
{
	public class TurtleWarriorEmblem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Turtle Warrior Emblem");
			Tooltip.SetDefault("Increases melee damage by 30%\n"
                             + "Gives +12% crit chance and +15% damage reduction\n"
                             + "'I already used this joke.'\n");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<LuckEEmblemPlayer>().TurtleWarriorEmblem = true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.TurtleShell, 2);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 20);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}