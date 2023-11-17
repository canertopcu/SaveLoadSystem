using Assets.Scripts.Main.SaveLoadSystem;
using System.Diagnostics;
using UnityEngine;

namespace Assets.Scripts
{
    public class Saver : MonoBehaviour
    {
        public GameData gameData; 
        void Start()
        {
             
        }
         
        public void SaveGame()
        {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); 

            stopwatch.Stop();
            UnityEngine.Debug.LogError(stopwatch.Elapsed.TotalMilliseconds);
        }

        public void SavePlayer()
        {  
        }


    }
}
