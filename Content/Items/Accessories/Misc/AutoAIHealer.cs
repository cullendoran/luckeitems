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
            Tooltip.SetDefault("Auto heals when needed\n" + "'AI is the future.'\n");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<LuckEPlayer>().autoAIHealer = true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<AIChip>();
            recipe.AddIngredient<HallowedWire>(15);
            recipe.AddIngredient<Capacitor>(4);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}