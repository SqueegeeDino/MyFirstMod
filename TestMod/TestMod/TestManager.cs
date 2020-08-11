using UnityEngine;
using UnityModManagerNet;

namespace TestMod
{

    public class KeyCodeInput
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                UnityModManager.Logger.Log("TestMod - Space key was pressed.");
            }

            if (Input.GetKeyUp(KeyCode.Space))
            {
                UnityModManager.Logger.Log("TestMod - Space key was released.");
            }
        }

        void Start()
        {
            UnityModManager.Logger.Log("TestMod - Update Working");
        }
    }
}