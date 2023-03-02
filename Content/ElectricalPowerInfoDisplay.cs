using luckeitems.Common.Players;
using System.Linq;
using Terraria;
using Terraria.ModLoader;

namespace luckeitems.Content
{
	// This example show how to create new informational display (like Radar, Watches, etc.)
	// Take a look at the ExampleInfoDisplayPlayer at the end of the file to see how to use it
	class ElectricalPowerInfoDisplay : InfoDisplay
	{
		public override void SetStaticDefaults() {
			// This is the name that will show up when hovering over icon of this info display
			InfoName.SetDefault("Electricity");
		}

		// This dictates whether or not this info display should be active
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<LuckEPlayer>().showElectricalPower;
		}

		// Here we can change the value that will be displayed in the game
		public override string DisplayValue() {
			int electricCount = Main.LocalPlayer.GetModPlayer<ElectricityResourcePlayer>().electricityResourceCurrent;
            int electricCountMax = Main.LocalPlayer.GetModPlayer<ElectricityResourcePlayer>().electricityResourceMax2;
            // This is the value that will show up when viewing this display in normal play, right next to the icon
			if (Main.LocalPlayer.GetModPlayer<LuckEPlayer>().isEStorageItemEquiped == true)
			{
                return electricCount > 0 ? $"{electricCount}/{electricCountMax} Electricity." : "No Electricity Stored!";
            }
			else
			{
                return $"No Electricity Storage Item Equipped!";
            }

        }

	}
}
