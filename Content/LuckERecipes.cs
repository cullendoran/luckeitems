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
            LuckERecipeGroup = new RecipeGroup(() => $"Any Mythril Bar",
                ItemID.MythrilBar, ItemID.OrichalcumBar);

            // To avoid name collisions, when a modded items is the iconic or 1st item in a recipe group, name the recipe group: ModName:ItemName
            RecipeGroup.RegisterGroup("luckeitems:MythrilBarGroup", LuckERecipeGroup);
        }

	}
}