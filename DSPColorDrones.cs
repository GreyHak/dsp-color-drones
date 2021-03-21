//
// Copyright (c) 2021, Aaron Shumate
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree. 
//
// Dyson Sphere Program is developed by Youthcat Studio and published by Gamera Game.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using System.Security;
using System.Security.Permissions;

[module: UnverifiableCode]
#pragma warning disable CS0618 // Type or member is obsolete
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]
#pragma warning restore CS0618 // Type or member is obsolete
namespace DSPColorDrones
{
    [BepInPlugin(pluginGuid, pluginName, pluginVersion)]
    [BepInProcess("DSPGAME.exe")]
    public class DSPColorDrones : BaseUnityPlugin
    {
        public const string pluginGuid = "greyhak.dysonsphereprogram.colordrones";
        public const string pluginName = "DSP Color Drones";
        public const string pluginVersion = "1.0.1";
        new internal static ManualLogSource Logger;
        //new internal static BepInEx.Configuration.ConfigFile Config;
        Harmony harmony;

        public void Awake()
        {
            Logger = base.Logger;  // "C:\Program Files (x86)\Steam\steamapps\common\Dyson Sphere Program\BepInEx\LogOutput.log"
            //Config = base.Config;  // "C:\Program Files (x86)\Steam\steamapps\common\Dyson Sphere Program\BepInEx\config\"

            harmony = new Harmony(pluginGuid);
            harmony.PatchAll(typeof(DSPColorDrones));
        }

        [HarmonyPostfix, HarmonyPatch(typeof(GameMain), "Resume")]
        public static void GameMain_Resume_Postfix()
        {
            MechaDroneLogic_ReloadStates_Postfix();
        }

        [HarmonyPostfix, HarmonyPatch(typeof(MechaDroneLogic), "ReloadStates")]
        public static void MechaDroneLogic_ReloadStates_Postfix()
        {
            Texture2D newTexture = new Texture2D(512, 512);

            // Original GameMain.mainPlayer.mecha.droneRenderer.mat_0.color = (0.175, 0.461, 1.000, 1.000) = 45, 118, 255

            string filePath = $"BepInEx/config/{pluginGuid}.png";
            if (System.IO.File.Exists(filePath))
            {
                byte[] fileData = System.IO.File.ReadAllBytes(filePath);
                newTexture.LoadImage(fileData);
                Logger.LogInfo($"Successfully loaded drone skin {filePath}");

                for (int x = 0; x < newTexture.width; x++)
                {
                    for (int y = 0; y < newTexture.height; y++)
                    {
                        Color pixel = newTexture.GetPixel(x, y);
                        newTexture.SetPixel(x, y, new Color(pixel.r, pixel.g, pixel.b, 0));
                    }
                }
                newTexture.Apply();

                // Original made up of 512x512 construction-drone-a.png, construction-drone-n.png, construction-drone-s.png
                // Changing this changes all drones simultaneously.
                // The change takes effect when MechaDroneRenderer.Draw is called which is called constantly.
                GameMain.mainPlayer.mecha.droneRenderer.mat_0.mainTexture = newTexture;
            }
            else
            {
                string cwd = System.IO.Directory.GetCurrentDirectory();
                Logger.LogWarning($"Unable to find drone skin at {cwd}/{filePath}");
            }
        }
    }
}
