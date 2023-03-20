using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace luckeitems.Content.Items.Materials.Misc
{
	public class CondensedMatter : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Condensed Matter");
            Tooltip.SetDefault("A little bit of everyone, condensed into a single item.\n"
                             + "♪ There's a little of me in everybody... ♪\n");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
			ItemID.Sets.SortingPriorityMaterials[Item.type] = 58;
		}

		public override void SetDefaults() {
			Item.maxStack = 999;
			Item.width = 12;
			Item.height = 12;
            Item.value = Item.sellPrice(gold: 1);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.KingSlimeTrophy);
            recipe.AddIngredient(ItemID.EyeofCthulhuTrophy);
            recipe.AddIngredient(ItemID.QueenBeeTrophy);
            recipe.AddIngredient(ItemID.SkeletronTrophy);
            recipe.AddIngredient(ItemID.DeerclopsTrophy);
            recipe.AddIngredient(ItemID.WallofFleshTrophy);
            recipe.AddIngredient(ItemID.QueenSlimeTrophy);
            recipe.AddIngredient(ItemID.SpazmatismTrophy);
            recipe.AddIngredient(ItemID.RetinazerTrophy);
            recipe.AddIngredient(ItemID.DestroyerTrophy);
            recipe.AddIngredient(ItemID.SkeletronPrimeTrophy);
            recipe.AddIngredient(ItemID.PlanteraTrophy);
            recipe.AddIngredient(ItemID.GolemTrophy);
            recipe.AddIngredient(ItemID.DukeFishronTrophy);
            recipe.AddIngredient(ItemID.FairyQueenTrophy);
            recipe.AddIngredient(ItemID.AncientCultistTrophy);
            recipe.AddIngredient(ItemID.MoonLordTrophy);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
        }
    }
}