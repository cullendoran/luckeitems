using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Common.Players;
using luckeitems.Content.DamageClasses;
using System.Collections.Generic;

namespace luckeitems.Content.Items.Weapons.Electrical
{
	public class StunBatton : ModItem
	{
		private int electricityResourceCost;
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Stun Batton"); // The (English) text shown below your weapon's name.

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 40; // The item texture's width.
			Item.height = 40; // The item texture's height.

			Item.useStyle = ItemUseStyleID.Swing; // The useStyle of the Item.
			Item.useTime = 20; // The time span of using the weapon. Remember in terraria, 60 frames is a second.
			Item.useAnimation = 20; // The time span of the using animation of the weapon, suggest setting it the same as useTime.
			Item.autoReuse = true; // Whether the weapon can be used more than once automatically by holding the use button.

			Item.DamageType = ModContent.GetInstance<ElectricalDamageClass>(); // Whether your item is part of the melee class.
			Item.damage = 10; // The damage your item deals.
			Item.knockBack = 6; // The force of knockback of the weapon. Maximum is 20
			Item.crit = 6; // The critical strike chance the weapon has. The player, by default, has a 4% critical strike chance.

			Item.UseSound = SoundID.DD2_LightningAuraZap; // The sound when the weapon is being used.

			electricityResourceCost = 5;
		}

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
			tooltips.Add(new TooltipLine(Mod, "Electricity Resource Cost", $"Uses {electricityResourceCost} Electricity"));
        }

        public override bool CanUseItem(Player player)
        {
			var electricityResourcePlayer = player.GetModPlayer<ElectricityResourcePlayer>();

			if (electricityResourcePlayer.electricityResourceCurrent >= electricityResourceCost)
			{
				electricityResourcePlayer.electricityResourceCurrent -= electricityResourceCost;
				return true;
			}

			return false;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            // Inflict the OnFire debuff for 1 second onto any NPC/Monster that this hits.
            // 60 frames = 1 second
            target.AddBuff(BuffID.Electrified, 180);
        }
    }
}
