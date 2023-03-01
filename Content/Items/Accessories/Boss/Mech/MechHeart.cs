using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Common.Players;
using luckeitems.Content.DamageClasses;

namespace luckeitems.Content.Items.Accessories.Boss.Mech
{
	public class MechHeart : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Mechanical Heart");
			Tooltip.SetDefault("Increases max charge x2\n" + "Increases electricial damage by 25%\n" + "But comes with a price...\n" + "'Funny Text'\n");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<ElectricityResourcePlayer>().electricityResourceMax2 *= 2;
			player.GetDamage<ElectricalDamageClass>() += 0.25f;
			player.statLifeMax2 -= 20;
		}
	}
}