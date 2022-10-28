using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace luckeitems.Content
{
	// This class contains thoughtful examples of item recipe creation.
	public class LuckERecipes : ModSystem
	{
		// A place to store the recipe group so we can easily use it later
		public static RecipeGroup LuckERecipeGroup;

		public override void Unload() {
			LuckERecipeGroup = null;
		}

		public override void AddRecipeGroups() {
            LuckERecipeGroup = new RecipeGroup(() => $"Any Titanium Ore",
               ItemID.TitaniumOre, ItemID.AdamantiteOre);

            // To avoid name collisions, when a modded items is the iconic or 1st item in a recipe group, name the recipe group: ModName:ItemName
            RecipeGroup.RegisterGroup("luckeitems:TitaniumOreGroup", LuckERecipeGroup);

            LuckERecipeGroup = new RecipeGroup(() => $"Any Mythril Bar",
                ItemID.MythrilBar, ItemID.OrichalcumBar);

            // To avoid name collisions, when a modded items is the iconic or 1st item in a recipe group, name the recipe group: ModName:ItemName
            RecipeGroup.RegisterGroup("luckeitems:MythrilBarGroup", LuckERecipeGroup);

            LuckERecipeGroup = new RecipeGroup(() => $"Any Evil Bar",
                ItemID.DemoniteBar, ItemID.CrimtaneBar);

            // To avoid name collisions, when a modded items is the iconic or 1st item in a recipe group, name the recipe group: ModName:ItemName
            RecipeGroup.RegisterGroup("luckeitems:EvilBarGroup", LuckERecipeGroup);

            LuckERecipeGroup = new RecipeGroup(() => $"Any Copper Bar",
                ItemID.CopperBar, ItemID.TinBar);

            // To avoid name collisions, when a modded items is the iconic or 1st item in a recipe group, name the recipe group: ModName:ItemName
            RecipeGroup.RegisterGroup("luckeitems:CopperBarGroup", LuckERecipeGroup);

            LuckERecipeGroup = new RecipeGroup(() => $"Any Iron Bar",
                ItemID.IronBar, ItemID.LeadBar);

            // To avoid name collisions, when a modded items is the iconic or 1st item in a recipe group, name the recipe group: ModName:ItemName
            RecipeGroup.RegisterGroup("luckeitems:IronBarGroup", LuckERecipeGroup);

            LuckERecipeGroup = new RecipeGroup(() => $"Any Tungsten Bar",
                ItemID.TungstenBar, ItemID.SilverBar);

            // To avoid name collisions, when a modded items is the iconic or 1st item in a recipe group, name the recipe group: ModName:ItemName
            RecipeGroup.RegisterGroup("luckeitems:TungstenBarGroup", LuckERecipeGroup);

            LuckERecipeGroup = new RecipeGroup(() => $"Any Platinum Bar",
                ItemID.PlatinumBar, ItemID.GoldBar);

            // To avoid name collisions, when a modded items is the iconic or 1st item in a recipe group, name the recipe group: ModName:ItemName
            RecipeGroup.RegisterGroup("luckeitems:PlatinumBarGroup", LuckERecipeGroup);

            LuckERecipeGroup = new RecipeGroup(() => $"Any Cobalt Bar",
                ItemID.CobaltBar, ItemID.PalladiumBar);

            // To avoid name collisions, when a modded items is the iconic or 1st item in a recipe group, name the recipe group: ModName:ItemName
            RecipeGroup.RegisterGroup("luckeitems:CobaltBarGroup", LuckERecipeGroup);

            LuckERecipeGroup = new RecipeGroup(() => $"Any Mythril Bar",
                ItemID.MythrilBar, ItemID.OrichalcumBar);

            // To avoid name collisions, when a modded items is the iconic or 1st item in a recipe group, name the recipe group: ModName:ItemName
            RecipeGroup.RegisterGroup("luckeitems:MythrilBarGroup", LuckERecipeGroup);

            LuckERecipeGroup = new RecipeGroup(() => $"Any Titanium Bar",
                ItemID.TitaniumBar, ItemID.AdamantiteBar);

            // To avoid name collisions, when a modded items is the iconic or 1st item in a recipe group, name the recipe group: ModName:ItemName
            RecipeGroup.RegisterGroup("luckeitems:TitaniumBarGroup", LuckERecipeGroup);
        }

	}
}