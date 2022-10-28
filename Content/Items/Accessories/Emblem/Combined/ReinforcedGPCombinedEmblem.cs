using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Content.Items.Accessories.Emblem.GP;
using luckeitems.Content.Items.Accessories.Emblem.ReinforcedGP;

namespace luckeitems.Content.Items.Accessories.Emblem.Combined
{
	public class ReinforcedGPCombinedEmblem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("ReinforcedGP Emblem");
            Tooltip.SetDefault("Increases all damage by 20%\n" + "Also gives you titanium armor buff.\n" + "'Teenage Mutant Ninja Turtles!'\n");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			// Add 2 of this class damage
			player.GetDamage(DamageClass.Generic) += 0.20f;
            player.hasTitaniumStormBuff = true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<ReinforcedGPWarriorEmblem>();
            recipe.AddIngredient<ReinforcedGPRangerEmblem>();
            recipe.AddIngredient<ReinforcedGPSorcererEmblem>();
            recipe.AddIngredient<ReinforcedGPSummonerEmblem>();
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}