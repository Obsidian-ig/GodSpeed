using BepInEx;
using Dissonance;
using GameNetcodeStuff;
using HarmonyLib;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Windows;

namespace LethalCompanyMods.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB))]

    internal class PlayerControllerBPatch
    {

        [HarmonyPatch(typeof(PlayerControllerB))]
        internal class PlayerControllerPatch
        {
            [HarmonyPatch("Update")]
            [HarmonyPostfix]
            private static void SpeedPatch(ref float ___sprintMultiplier)
            {
                ___sprintMultiplier = 4f;
            }
        }

    }
}
