using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Common.Players;

namespace luckeitems.Content.Items.Accessories.Boss.Mech
{
	public class SoulOfCorruption : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Soul of Corruption");
			Tooltip.SetDefault("Makes your weapons inflict cursed flames\n" + "'Keep cursing and I'll wash your mouth out with soap!'\n");

            Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(5, 4));
            ItemID.Sets.AnimatesAsSoul[Item.type] = true;

            ItemID.Sets.ItemIconPulse[Item.type] = true; // The item pulses while in the player's inventory

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.GetModPlayer<LuckEPlayer>().HasSoulOfCorruptionAcc = true;
        }
    }
}