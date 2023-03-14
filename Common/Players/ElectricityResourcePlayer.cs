using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using IL.Terraria.GameContent;

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
        public static readonly Color HealElectricityResource = new(255, 255, 0);
        public int gelItem; // Unused
        public float windSpeed;
        public int windSpeedNew;
        public int windSpeedFinal;
        internal int eGenRetryTimer = 0;
        internal int gelLeftTimer = 0;
        internal int gelGenRegenTimer = 0;
        internal int windGenRegenTimer = 0;

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
            windSpeed = Main.windSpeedCurrent * 100;
            windSpeedNew = (int)windSpeed;
            if (windSpeedNew < 0)
            {
                windSpeedFinal = windSpeedNew * -1;
            }
            else if (windSpeedNew > 0)
            {
                windSpeedFinal = windSpeedNew;
            }
            if (Main.LocalPlayer.GetModPlayer<LuckEPlayer>().isEGeneratorItemEquiped)
            {
                if (Main.LocalPlayer.GetModPlayer<LuckEPlayer>().windGenerator)
                {
                    if (electricityResourceCurrent != electricityResourceMax2)
                    {
                        if (windSpeedFinal > 0)
                        {
                            windGenRegenTimer++;
                        }
                        if (windGenRegenTimer > 240)
                        {
                            electricityResourceCurrent += windSpeedFinal / 8;
                            windGenRegenTimer = 0;
                        }
                    }
                }

                if (Main.LocalPlayer.GetModPlayer<LuckEPlayer>().gelGenerator)
                {
                    if (electricityResourceCurrent != electricityResourceMax2)
                    {
                        if (gelLeftTimer > 0)
                        {
                            gelGenRegenTimer++;
                        }

                        if (Player.HasItem(ItemID.PinkGel))
                        {
                            if (gelLeftTimer == 0)
                            {
                                Player.ConsumeItem(ItemID.PinkGel);
                                gelLeftTimer = 1000;
                            }
                        }

                        if (Player.HasItem(ItemID.Gel) && !Player.HasItem(ItemID.PinkGel))
                        {

                            if (gelLeftTimer == 0)
                            {
                                Player.ConsumeItem(ItemID.Gel);
                                gelLeftTimer = 500;
                            }

                        }

                        if (gelGenRegenTimer > 180 && gelLeftTimer > 0)
                        {
                            electricityResourceCurrent += 1;
                            gelGenRegenTimer = 0;
                        }

                        if (gelLeftTimer > 0)
                        {
                            gelLeftTimer -= 1;
                        }

                    }
                }
            }

            electricityResourceCurrent = Utils.Clamp(electricityResourceCurrent, 0, electricityResourceMax2);

        }
    }
}
