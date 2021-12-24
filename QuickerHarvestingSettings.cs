using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModSettings;
using UnityEngine;

namespace QuickerHarvesting
{
    internal class QuickerHarvestingSettings : JsonModSettings
    {
        [Name("Harvest Times")]
        [Description("Modify the time value in seconds")]
        [Slider(.1f, 5f)]
        public float HarvestTimeModifier = 1f;

    }
}
