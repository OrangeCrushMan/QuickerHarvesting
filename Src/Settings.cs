using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModSettings;

namespace QuickerHarvesting
{
    internal static class Settings 
    {
        internal static void OnLoad() 
        {
            Settings.options = new QuickerHarvestingSettings();
            Settings.options.AddToModSettings("Quicker Harvesting Settings");
        }
        internal static QuickerHarvestingSettings options;
    }
}
        

