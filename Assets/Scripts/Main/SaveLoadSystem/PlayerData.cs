using Newtonsoft.Json;

namespace Assets.Scripts.Main.SaveLoadSystem
{
    [System.Serializable]
    public class PlayerData : IData
    {
        // Add fields to store the game state.
        public int playerId;
        public string playerName;
        public int revenue;

        public void Merge(IData newData)
        {
            if (newData is PlayerData playerData)
            {
                playerId = playerData.playerId;
                playerName = playerData.playerName;
                revenue = playerData.revenue;
            }
        } 
    }
}
