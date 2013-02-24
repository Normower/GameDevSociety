using UnityEngine;
using System.Collections;

/*
        Created by Matt Norman for Game Dev Society
  
            Simple script to fire bullets, if using the character controller attach it to the main camera.
*/

public class Shoot : MonoBehaviour {

    public GameObject bulletPrefab; //set the object that you want to spawn as a bullet in the inspector, it must have a rigidbody
    private GameObject bullet;
    public float power; //the amount of force/speed you wish to apply to the bullet, can be set in the inspector
  
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) //use left click to fire
            Shoot();        
	}
    
    void Shoot() {
        bullet = (GameObject)Instantiate(bulletPrefab, transform.position, transform.rotation);
        //bullet.rigidbody.AddForce(bullet.transform.forward * power); //if you want add a force instead
        bullet.rigidbody.velocity = (bullet.transform.forward * power);
    }
}
