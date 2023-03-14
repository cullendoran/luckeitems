using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;
using luckeitems.Content.Items.Materials.Ore;
using luckeitems.Content.Tiles.Crafting;

namespace luckeitems.Content.Items.Materials.Electricial
{
	public class AIChip : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("AI Chip");
            Tooltip.SetDefault("Strange, infusing the souls of the three mechanical beasts with a electronic device and binding it with silicon has resulted in a supernatural AI.\n"
                             + "'FUNNY TEXT'\n");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 25; // How many items are needed in order to research duplication of this item in Journey mode. See https://terraria.gamepedia.com/Journey_Mode/Research_list for a list of commonly used research amounts depending on item type.
		}

		public override void SetDefaults() {
			Item.width = 26; // The item texture's width
			Item.height = 28; // The item texture's height

			Item.maxStack = 999; // The item's max stack value
        }

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SoulofMight, 2);
            recipe.AddIngredient(ItemID.SoulofSight, 2);
            recipe.AddIngredient(ItemID.SoulofFright, 2);
            recipe.AddIngredient<LED>(1);
            recipe.AddIngredient<CircuitBoard>(1);
            recipe.AddIngredient<Silicon>(9);
            recipe.AddIngredient<TitaniumWire>(4);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile<ElectricBench>();
            recipe.Register();
        }

		// Researching the Example item will give you immediate access to the torch, block, wall and workbench!
	}
}
