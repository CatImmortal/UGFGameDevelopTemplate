﻿using UnityEditor;
using UnityEngine;

namespace GDT.Editor
{
    [CustomEditor(typeof(DeviceModelConfig))]
    public class DeviceModelConfigInspector : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            if (GUILayout.Button("Open Device Model Config Editor"))
            {
                DeviceModelConfigEditorWindow.OpenWindow((DeviceModelConfig)target);
            }
        }
    }
}
