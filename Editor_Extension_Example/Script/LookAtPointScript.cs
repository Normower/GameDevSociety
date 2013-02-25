using UnityEngine;
using System.Collections;
using UnityEditor;

[ExecuteInEditMode()]  
public class LookAtPointScript : MonoBehaviour {

   [SerializeField]
    private Vector3 lookAtPoint;

    public Vector3 LookAtPoint
    {
        get { return lookAtPoint; }
        set
        {
            lookAtPoint = value;
        }
    }

    void Update()
    {
        transform.LookAt(lookAtPoint);
    }
}





