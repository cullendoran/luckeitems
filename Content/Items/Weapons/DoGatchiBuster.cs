using luckeitems.Content;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace luckeitems.Content.Items.Weapons
{
	public class DoGatchiBuster : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Ripped from the Digimon Universe!");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 250;
			Item.DamageType = DamageClass.Magic; // Makes the damage register as magic. If your item does not have any damage type, it becomes true damage (which means that damage scalars will not affect it). Be sure to have a damage type.
			Item.width = 34;
			Item.height = 40;
			Item.useTime = 10;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Shoot; // Makes the player use a 'Shoot' use style for the Item.
			Item.noMelee = true; // Makes the item not do damage with it's melee hitbox.
			Item.knockBack = 0;
			Item.value = 0;
			Item.rare = ItemRarityID.Expert;
			Item.UseSound = SoundID.Item12;
			Item.autoReuse = true;
			Item.shoot = ProjectileID.GreenLaser; // Shoot a black bolt, also known as the projectile shot from the onyx blaster.
			Item.shootSpeed = 10; // How fast the item shoots the projectile.
			Item.crit = 32; // The percent chance at hitting an enemy with a crit, plus the default amount of 4.
			Item.mana = 6; // This is how much mana the item uses.
		}

		// Recipe for testing purposes
//        public override void AddRecipes()
//        {
//            Recipe recipe = CreateRecipe();
//			recipe.AddRecipeGroup("luckeitems:MythrilBarGroup", 25);
//            recipe.AddIngredient(ItemID.Ruby, 8);
//            recipe.AddTile(TileID.MythrilAnvil);
//            recipe.AddTile(TileID.AdamantiteForge);
//            recipe.Register();
//        }
    }
}
