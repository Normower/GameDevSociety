using UnityEngine;
using System.Collections;
using UnityEditor;


[CustomEditor(typeof(LookAtPointScript))]
public class LookAtPointEditor : Editor
{

    public override void OnInspectorGUI()
    {
        LookAtPointScript myTarget = (LookAtPointScript)target;
        myTarget.LookAtPoint = EditorGUILayout.Vector3Field("Look At Point", myTarget.LookAtPoint);
        if (GUI.changed)
        {
            EditorUtility.SetDirty(target);
        }
        
    }
}
