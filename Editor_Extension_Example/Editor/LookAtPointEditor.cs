using UnityEngine;
using System.Collections;
using UnityEditor;

/*
        Created by Matt Norman for Game Dev Society
  
            This creates the editor for LookAtPointScript, place it in "Editor" folder inside of assets.
*/

[CustomEditor(typeof(LookAtPointScript))]//references the class we want to create an editor for.
public class LookAtPointEditor : Editor
{
    public override void OnInspectorGUI()
    {
        LookAtPointScript myTarget = (LookAtPointScript)target;//access point to the class's functions, variables etc.
        myTarget.LookAtPoint = EditorGUILayout.Vector3Field("Look At Point", myTarget.LookAtPoint);//creates a vector3 field
        if (GUI.changed)
        {
            EditorUtility.SetDirty(target);//sets the changes
        }        
    }
}
