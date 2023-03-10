using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using luckeitems.Content.DamageClasses;
using System.Collections.Generic;
using luckeitems.Content.Items.Materials.Electricial;
using luckeitems.Content.Items.Accessories.Power.Storage;

namespace luckeitems.Content.Items.Weapons.Electrical.StunBatton
{
	public class StunBattonNormal : ModItem
	{

        public override string Texture => "luckeitems/Content/Items/Weapons/Electrical/StunBatton/StunBatton";
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Stun Batton - Normal Mode");
            Tooltip.SetDefault("Stun Batton"); // The (English) text shown below your weapon's name.

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 40; // The item texture's width.
			Item.height = 40; // The item texture's height.
			Item.DamageType = ModContent.GetInstance<ElectricalDamageClass>(); // Whether your item is part of the melee class.
			Item.crit = 6; // The critical strike chance the weapon has. The player, by default, has a 4% critical strike chance.
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 10;
            Item.useAnimation = 10;
            Item.autoReuse = true;
            Item.damage = 10;
            Item.knockBack = 6;
            Item.UseSound = SoundID.DD2_OgreGroundPound;
        }

        public override bool CanRightClick()
        {
            Main.LocalPlayer.PutItemInInventoryFromItemUsage(ModContent.GetInstance<StunBattonStun>().Type);
            Item.TurnToAir();
            return true;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips.Add(new TooltipLine(Mod, "Stun Mode Convert To Normal", $"Right Click in Inventory to Change Mode"));
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<CopperWire>(8);
            recipe.AddIngredient<SimpleBattery>();
            recipe.AddRecipeGroup("luckeitems:PlatinumBarGroup", 20);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}
