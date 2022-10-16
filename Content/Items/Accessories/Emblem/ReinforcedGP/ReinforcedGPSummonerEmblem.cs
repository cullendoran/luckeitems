using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace luckeitems.Content.Items.Accessories.Emblem.ReinforcedGP
{
	public class ReinforcedGPSummonerEmblem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("ReinforcedGP Ranger Emblem");
            Tooltip.SetDefault("Increases summon damage by 20%\n" + "Also gives you titanium armor buff.\n" + "'I like turtles!'\n");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            // Add 4% of this class damage
            player.GetDamage(DamageClass.Summon) += 0.20f;
            player.hasTitaniumStormBuff = true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Items.Materials.Bar.ReinforcedGPBar>(5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}