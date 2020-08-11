using UnityEngine;
using UnityModManagerNet;

namespace TestMod
{
    static class Main
    {
        public static bool enabled;
        public static string health;
        public static string ammo;

        static bool Load(UnityModManager.ModEntry modEntry)
        {
            modEntry.OnGUI = OnGUI;
            return true;
        }

        static void OnGUI(UnityModManager.ModEntry modEntry)
        {

        }
    }
}