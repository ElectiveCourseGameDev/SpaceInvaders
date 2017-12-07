using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {
    public int bullets;
    public int bulletsAllowed;
    public float movement;
    private GameObject sound;
	// Use this for initialization
	void Start () {
		sound = GameObject.FindGameObjectWithTag("Sound");
	}
	
	// Update is called once per frame
	void Update () {
	    // for android touch
	    if (Input.touchCount > 0)
	    {
	        //Debug.Log("Pos: " + Input.touches[0].position);
            
	        // first finger is shooting
	        
	        foreach (Touch touch in Input.touches)
	        {
	            if (touch.phase == TouchPhase.Began)
	            {
	                if (bullets < bulletsAllowed)
	                {
	                    shoot();
	                }
                }
	            if (touch.phase == TouchPhase.Moved)
	            {
	                Debug.Log("moved");
                }
	            Debug.Log(touch.phase.ToString());

            }
	    }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (bullets < bulletsAllowed)
            {
                shoot();
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x >-8.5f)
        {
            transform.Translate(Vector2.left * movement);
        }

        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x <=8.5f)
        {
            transform.Translate(Vector2.right * movement);
        }
    }

    private void shoot()
    {
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
