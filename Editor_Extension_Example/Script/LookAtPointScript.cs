using UnityEngine;
using System.Collections;
using UnityEditor;

/*
        Created by Matt Norman for Game Dev Society
  
            The script we are creating a custom editor for. It simply has an onject face a specific position.
*/

[ExecuteInEditMode()]//script is active in the editor, allows us to see live changes.  
public class LookAtPointScript : MonoBehaviour {

   [SerializeField]//saves changes made
    private Vector3 lookAtPoint;

    public Vector3 LookAtPoint//it's bad code practice to expose variables, by using this we can apply our own validation.
    {
        get { return lookAtPoint; }
        set
        {
           //some form of validation if we needed it.
            lookAtPoint = value;
        }
    }

    void Update()
    {
        transform.LookAt(lookAtPoint);
    }
}





