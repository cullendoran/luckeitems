using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Common.Players;
using luckeitems.Content.Items.Materials.Electricial;

namespace luckeitems.Content.Items.Accessories.Misc
{
	public class AutoAIHealer : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("AI Healer");
            Tooltip.SetDefault("Auto heals when needed\n" + "Gives +2 Damage\n" + "'AI is the future.'\n");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Generic).Flat += 2;
            player.GetModPlayer<LuckEPlayer>().autoAIHealer = true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<AIChip>();
            recipe.AddIngredient<CopperWire>(50);
            recipe.AddIngredient(ItemID.HallowedBar, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}