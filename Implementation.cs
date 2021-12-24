﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using UnityEngine;


namespace QuickerHarvesting
{
    public class Implementation : MelonMod
    {
        public override void OnApplicationStart()
        { 
            Debug.Log($"[{ Info.Name}] Version {Info.Version} Loaded!");
            Settings.OnLoad();
        }
    }
}
