using UnityModManagerNet;
using UnityEngine;

namespace TestMod
{
    static class Main
    {
        // Simply call. Compiled without dependencies on UnityModManagerNet
        static void Load()
        {
            // Something
        }

        // Send a response to the mod manager about the launch status, success or not.
        static bool Load(UnityModManager.ModEntry modEntry)
        {
            UnityModManager.Logger.Log("TestMod - Squeegee Sucks");
            return true; // If false the mod will show an error.
        }
    }
}