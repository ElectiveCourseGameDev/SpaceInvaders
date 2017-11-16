using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceShipShooting : MonoBehaviour {

    public float coolDown = 1;
    private float nextShot= Time.fixedTime;
    // Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (isCoolDown())
        {
            instansiateBullet();

            Debug.Log("!#¤");
        }
	}

    private bool isCoolDown()
    {
        if (Time.fixedTime > nextShot)
        {
            nextShot = Time.fixedTime + coolDown;
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
