using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace luckeitems.Content.Items.Accessories.Emblem.Wood
{
	public class WoodWarriorEmblem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Wooden Warrior Emblem");
			Tooltip.SetDefault("Increases melee damage by 2\n"
							 + "'You really are desperate aren't you?'\n");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			// Add 2 of this class damage
			player.GetDamage(DamageClass.Melee).Flat += 2f;
		}
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}