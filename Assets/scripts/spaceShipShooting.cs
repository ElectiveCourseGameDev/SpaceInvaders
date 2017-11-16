using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceShipShooting : MonoBehaviour {

    public float coolDown = 1;
    private float timeLastShot= 0;
    // Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (isCoolDown())
        {
            Debug.Log("!#¤");
        }
        instansiateBullet();
	}

    private bool isCoolDown()
    {
        if (Time.time > timeLastShot+coolDown)
        {
            timeLastShot = Time.time;
            return true;
        }
        return false;
    }

    private void instansiateBullet()
    {
        // create instance from Prefab
        GameObject bullet = Instantiate(Resources.Load("Bullet", typeof(GameObject))) as GameObject;

        // set bullet position to this position
        bullet.transform.position = transform.position;
    }
}
