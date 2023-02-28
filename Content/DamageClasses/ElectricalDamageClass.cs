using System;
using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace luckeitems.Content.DamageClasses
{
	public class ElectricalDamageClass : DamageClass
	{
        public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == DamageClass.Generic)
				return StatInheritanceData.Full;

			return new StatInheritanceData(
				damageInheritance: 0f,
				critChanceInheritance: 0f,
				attackSpeedInheritance: 0f,
				armorPenInheritance: 0f,
				knockbackInheritance: 0f
			);
		}

		public override bool GetEffectInheritance(DamageClass damageClass) {
			if (damageClass == DamageClass.Melee)
				return true;
			if (damageClass == DamageClass.Ranged)
				return true;

			return false;
		}

		public override void SetDefaultStats(Player player) {

		}
		public override bool UseStandardCritCalcs => true;

		public override bool ShowStatTooltipLine(Player player, string lineName) {
			return true;
		}
	}
}