using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace SanguophageFaction
{
    class SanguophageModSettings : ModSettings
    {
		public static float SanguophageChance = 1f;

		public override void ExposeData()
		{
			base.ExposeData();
			Scribe_Values.Look(ref SanguophageChance, "SanguophageChance", 1f);
		}
	}
}
