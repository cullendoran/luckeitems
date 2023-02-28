using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace luckeitems.Content.Items.Accessories.Mega
{
	public class PureAscension : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Pure Ascension");
            Tooltip.SetDefault("Gives effects of EVERYTHING\n" + "'Godlike!'\n" + "DOES NOT DO ANYTHING YET");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
		}
    }
}