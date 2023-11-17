using Assets.Scripts.Main.SaveLoadSystem;
using UnityEngine;
using UnityEngine.Playables;

public class Loader : MonoBehaviour
{
    public GameData gameData;
    public PlayerData playerData;

     void Start()
     {
          
     }
    public void Load()
    {  
        DataPersistenceManager.instance.LoadData();
    }

}
