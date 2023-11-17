using UnityEditor;
using UnityEngine;

namespace Assets.Scripts
{
    [CustomEditor(typeof(Loader))]
    public class LoaderEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            Loader loader = (Loader)target;

            base.OnInspectorGUI();
            if (GUILayout.Button("Load"))
            {
                loader.Load();
            }
        }
    }
}
