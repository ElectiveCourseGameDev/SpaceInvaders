using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {
    public int bullets;
    public int bulletsAllowed;
    public float movement;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shoot();
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * movement);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * movement);
        }

    }

    private void shoot()
    {
        GameObject bullet = Instantiate(Resources.Load("Bullet", typeof(GameObject))) as GameObject;
        bullet.transform.position = transform.position;
        bullets++;
    }

    public void removeBullet()
    {
        bullets--;
    }

    void increaseAllowedBullets()
    {
        bulletsAllowed++;
    }

    void decreaseAllowedBullets()
    {
        bulletsAllowed--;
    }

    void increaseAllowedBullets(int amount)
    {
        bulletsAllowed += amount;
    }

    void decreaseAllowedBullets(int amount)
    {
        bulletsAllowed -= amount;
    }
}
