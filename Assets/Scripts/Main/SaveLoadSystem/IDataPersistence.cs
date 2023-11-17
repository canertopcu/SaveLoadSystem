using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Main.SaveLoadSystem
{
    public interface IDataPersistence
    {
        void LoadData(GameData data);

        void SaveData(GameData data);

    }
}
