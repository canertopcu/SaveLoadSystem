using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Assets.Scripts.Main.SaveLoadSystem
{
    public static class SaveLoadSystem
    {
        private static Dictionary<string, IData> dataStorage = new Dictionary<string, IData>();
        private static string savePath = Application.persistentDataPath + "/save.json";
        
        public static void Save<T>(T data) where T : IData
        {
            Type dataType = data.GetType();

            if (dataStorage.TryGetValue(dataType.ToString(), out IData existingData))
            {
                // Merge the new data with existing data
                existingData.Merge(data);
            }
            else
            {
                // Store new data
                dataStorage[dataType.ToString()] = data;
            }

            // Serialize the entire dataStorage to a JSON string
            string serializedData = JsonConvert.SerializeObject(dataStorage);

            Debug.Log(serializedData);
            // Save the JSON data to the file
            File.WriteAllText(savePath, serializedData);
        }

        public static T Load<T>() where T : IData, new()
        { 
            if (File.Exists(savePath))
            {
                string serializedData = File.ReadAllText(savePath);
                //JsonConvert.DeserializeObject<Dictionary<string, IData>>(serializedData);
                var deserializedData = JsonConvert.DeserializeObject<Dictionary<string, T>>(serializedData);
                // Now you can retrieve the data of the specific type
                Type dataType = typeof(T);
                if (deserializedData.TryGetValue(dataType.ToString(), out T existingData))
                {
                    return (T)existingData;
                }
            }
            else
            {
                Debug.LogError("Save file not found in " + savePath);
            }

            return new T();
        }

    }
}

