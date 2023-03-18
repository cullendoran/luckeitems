using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace luckeitems.Content.Items.Accessories.Emblem.Combined
{
	public class ReinforcedGPCombinedEmblem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("ReinforcedGP Emblem");
            Tooltip.SetDefault("Increases all damage by 20%\n" + "Also gives you titanium armor buff.\n" + "'Teenage Mutant Ninja Turtles!'\n");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			// Add 2 of this class damage
			player.GetDamage(DamageClass.Generic) += 0.20f;
            player.hasTitaniumStormBuff = true;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips.Insert(index: 2, new TooltipLine(Mod, "Deprecated Notice 2", $"[c/ff0000:HOWEVER YOU CAN STILL USE THIS ITEM BEFORE IT IS REMOVED]"));
            tooltips.Insert(index: 2, new TooltipLine(Mod, "Deprecated Notice", $"[c/ff0000:WARNING: THIS ITEM IS NOW NO LONGER BEING UPDATED AND WILL BE REMOVED IN A FUTURE UPDATE!]"));
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<ReinforcedGP.ReinforcedGPWarriorEmblem>();
            recipe.AddIngredient<ReinforcedGP.ReinforcedGPRangerEmblem>();
            recipe.AddIngredient<ReinforcedGP.ReinforcedGPSorcererEmblem>();
            recipe.AddIngredient<ReinforcedGP.ReinforcedGPSummonerEmblem>();
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}