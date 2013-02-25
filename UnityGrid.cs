using UnityEngine;
using System.Collections;

/*
        Created by Matt Norman for Game Dev Society
  
            Simple script to create a grid.
*/

public class Grid : MonoBehaviour
{

    public GameObject tilePrefab;//Select object you wish to populateeach gridcell, if x = 1 or z = 1 on the scale, it will be too big (note that planes 10x are larger than other objects).
    private GameObject[,] gridArray;
    private const int gridX = 25;//Size on x axis
    private const int gridZ = 25;//Size on z axis

    void Awake()
    {
        GridCreate();
    }

    void GridCreate()//This isn't very flible int terms of gridcell size or grid placement, but hopefully is easier to read. The first gridcell will be at vector3(0,0,0).
    {
        gridArray = new GameObject[gridX, gridZ];
        for (int i = 0; i < gridX; i++)//Loops through the array and populates it
        {
            for (int j = 0; j < gridZ; j++)
            {
                gridArray[i, j] = (GameObject)Instantiate(tilePrefab, new Vector3(i, 0, j), Quaternion.identity);//Creates gridcell and adds it to the array
            }
        }
    }
}
