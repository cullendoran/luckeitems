using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Common.Players;
using luckeitems.Content.DamageClasses;
using System.Collections.Generic;
using luckeitems.Content.Buffs;

namespace luckeitems.Content.Items.Weapons.Electrical.StunBatton
{
	public class StunBattonStun : ModItem
	{
		private int electricityResourceCost;

        public override string Texture => "luckeitems/Content/Items/Weapons/Electrical/StunBatton/StunBatton";
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Stun Batton - Stun Mode");
            Tooltip.SetDefault("Stun Batton"); // The (English) text shown below your weapon's name.

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 40; // The item texture's width.
			Item.height = 40; // The item texture's height.

			Item.DamageType = ModContent.GetInstance<ElectricalDamageClass>(); // Whether your item is part of the melee class.
			Item.crit = 6; // The critical strike chance the weapon has. The player, by default, has a 4% critical strike chance.
            Item.useStyle = ItemUseStyleID.Thrust;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.autoReuse = false;
            Item.damage = 20;
            Item.knockBack = 0;
            Item.UseSound = SoundID.DD2_LightningBugZap;
            electricityResourceCost = 5;
		}

        public override bool CanRightClick()
        {
            Main.LocalPlayer.PutItemInInventoryFromItemUsage(ModContent.GetInstance<StunBattonNormal>().Type);
            Item.TurnToAir();
            return true;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips.Insert(index: 2, new TooltipLine(Mod, "Electricity Resource Cost", $"Uses {electricityResourceCost} Electricity"));
            tooltips.Add(new TooltipLine(Mod, "Stun Mode Convert To Normal", $"Right Click in Inventory to Change Mode"));
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
            target.AddBuff(BuffID.Electrified, 240);
        }
    }
}
