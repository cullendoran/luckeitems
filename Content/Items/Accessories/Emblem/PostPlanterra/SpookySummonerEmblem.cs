using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Common.Players;

namespace luckeitems.Content.Items.Accessories.Emblem.PostPlanterra
{
	public class SpookySummonerEmblem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Spooky Summoner Emblem");
			Tooltip.SetDefault("Increases summon damage by 30%\n"
                             + "Gives +4 max minions and +20% move speed\n"
                             + "'It's the spooky month!'\n");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.GetModPlayer<LuckEEmblemPlayer>().SpookySummonerEmblem = true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SpookyWood, 20);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}