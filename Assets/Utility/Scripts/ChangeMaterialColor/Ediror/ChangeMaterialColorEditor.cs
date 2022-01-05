using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ChangeMaterialColor))]
public class ChangeMaterialColorEditor : Editor
{
    ChangeMaterialColor script;

    private void OnEnable()
    {
        script = target as ChangeMaterialColor;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
            script.ChangeColor();
    }
}