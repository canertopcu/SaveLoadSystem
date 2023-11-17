using Assets.Scripts.Main.SaveLoadSystem;
using UnityEngine;

namespace Assets.Scripts
{
    public class DeathCountController : MonoBehaviour, IDataPersistence
    {
        public int DeathCount { get; private set; }
        public void LoadData(GameData data)
        {
            DeathCount = data.deathCount;
        }

        public void SaveData(GameData data)
        {
            data.deathCount = DeathCount;
        } 
    }
}
