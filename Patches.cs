using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using UnityEngine;

namespace QuickerHarvesting
{
    class Patches
    {
        [HarmonyLib.HarmonyPatch(typeof(Harvestable), "DoHarvest")]

        internal class Harvestable_DoHarvest
        {
            private static void Prefix(Harvestable __instance)
            {
                __instance.m_SecondsToHarvest = Settings.options.HarvestTimeModifier;
            }

        }

    }
}
    

