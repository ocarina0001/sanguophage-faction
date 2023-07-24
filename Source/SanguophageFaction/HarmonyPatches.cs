using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using RimWorld;
using Verse;

namespace SanguophageFaction
{
    [StaticConstructorOnStartup]
    internal static class HarmonyPatches
    {
		static HarmonyPatches()
		{
			Harmony val = new Harmony("ocarina.sanguophage.faction");
			val.PatchAll(Assembly.GetExecutingAssembly());
		}

        [HarmonyPostfix]
        private static void Postfix(FactionDef __instance)
        {
            if (__instance.defName == "OCARINA_SanguophageFaction")
            {
                SanguophageModSettings settings = LoadedModManager.GetMod<SanguophageMod>().GetSettings<SanguophageModSettings>();
            }
        }
    }
}
