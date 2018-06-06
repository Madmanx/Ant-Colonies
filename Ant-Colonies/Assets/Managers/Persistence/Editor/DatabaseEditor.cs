using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using DatabaseClass;
using UnityEngine;

[CustomEditor(typeof(Database))]
public class DatabaseEditor : Editor
{

    Database comp;

    public void OnEnable()
    {
        comp = (Database)target;
    }

    public override void OnInspectorGUI()
    {
        if (GUILayout.Button("Reset Database"))
            comp.ResetAll();

        base.OnInspectorGUI();

        EditorUtility.SetDirty(comp);
    }

}
