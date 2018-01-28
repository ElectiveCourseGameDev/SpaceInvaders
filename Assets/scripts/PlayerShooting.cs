using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {
    public int bullets;
    public int bulletsAllowed;
    
    private GameObject sound;

    
   
    // Use this for initialization
	void Start () {
		sound = GameObject.FindGameObjectWithTag("Sound");
	}
	
	
    private void shoot()
    {
        if (bullets >= bulletsAllowed) return;
            sound.SendMessage("playSound", SoundEngine.Sound.Lasershot);

        GameObject bullet = Instantiate(Resources.Load("Bullet", typeof(GameObject))) as GameObject;
        bullet.transform.position = transform.position;
        bullet.GetComponent<bulletScript>().owner = gameObject;
        bullets++;
    }

    public void removeBullet()
    {
        //Debug.Log("remove bullet called");
        bullets--;
        if (bullets < 0) bullets = 0;
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
