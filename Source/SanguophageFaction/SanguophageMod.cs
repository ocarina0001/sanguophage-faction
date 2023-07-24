using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using UnityEngine;

namespace SanguophageFaction
{
    public class SanguophageMod : Mod
    {
        private SanguophageModSettings settings;

        public SanguophageMod(ModContentPack con)
            : base(con)
        {
            settings = GetSettings<SanguophageModSettings>();
        }

        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listing_Standard = new Listing_Standard();
            listing_Standard.Begin(inRect);
            listing_Standard.Label("Sanguophage Chance");
            SanguophageModSettings.SanguophageChance = listing_Standard.Slider(SanguophageModSettings.SanguophageChance, 0f, 1f);
            listing_Standard.Label("Debug lol");
            listing_Standard.End();
            base.DoSettingsWindowContents(inRect);
        }

        public override string SettingsCategory()
        {
            return "Sanguophage Faction";
        }
    }
}
