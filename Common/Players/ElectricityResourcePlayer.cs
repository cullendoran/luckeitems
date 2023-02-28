using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace luckeitems.Common.Players
{
    public class ElectricityResourcePlayer : ModPlayer
    {
        public int electricityResourceCurrent;
        public const int DefaultElectricityResourceMax = 0;
        public int electricityResourceMax;
        public int electricityResourceMax2;
        public float electricityResourceRegenRate;
        internal int electricityResourceRegenTimer = 0;
        public static readonly Color HealElectricityResource = new(187, 92, 201);

        public override void Initialize()
        {
            electricityResourceMax = DefaultElectricityResourceMax;
        }

        public override void ResetEffects()
        {
            ResetVariables();
        }

        public override void UpdateDead()
        {
            ResetVariables();
        }

        // We need this to ensure that regeneration rate and maximum amount are reset to default values after increasing when conditions are no longer satisfied (e.g. we unequip an accessory that increaces our recource)
        private void ResetVariables()
        {
            electricityResourceRegenRate = 1f;
            electricityResourceMax2 = electricityResourceMax;
        }

        public override void PostUpdateMiscEffects()
        {
            UpdateResource();
        }

        // Lets do all our logic for the custom resource here, such as limiting it, increasing it and so on.
        private void UpdateResource()
        {
            // For our resource lets make it regen slowly over time to keep it simple, let's use exampleResourceRegenTimer to count up to whatever value we want, then increase currentResource.
            electricityResourceRegenTimer++; // Increase it by 60 per second, or 1 per tick.

            // A simple timer that goes up to 3 seconds, increases the exampleResourceCurrent by 1 and then resets back to 0.
            if (electricityResourceRegenTimer > 180 / electricityResourceRegenRate)
            {
                electricityResourceCurrent += 1;
                electricityResourceRegenTimer = 0;
            }

            // Limit exampleResourceCurrent from going over the limit imposed by exampleResourceMax.
            electricityResourceCurrent = Utils.Clamp(electricityResourceCurrent, 0, electricityResourceMax2);

        }
    }
}
