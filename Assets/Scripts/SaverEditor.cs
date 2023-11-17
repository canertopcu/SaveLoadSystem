using System.Diagnostics;
using UnityEditor;
using UnityEngine;

namespace Assets.Scripts
{
    [CustomEditor(typeof(Saver))]
    public class SaverEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            Saver saver = (Saver)target;

            base.OnInspectorGUI();
            if (GUILayout.Button("SaveGame"))
            { 
                saver.SaveGame(); 
            }

            if (GUILayout.Button("SavePlayer"))
            {
                saver.SavePlayer();
            }
        }
    }
}
 