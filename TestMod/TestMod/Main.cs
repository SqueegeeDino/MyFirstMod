using UnityEngine;
using UnityModManagerNet;

namespace TestMod
{
    static class Main
    {
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