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

    public float leftBoundaries =  -4;
    public float rightBoundaries = +4;

    public float deadzone = 5;

    public enum gesture { swipeLeft, swipeRight, tap};

    // Use this for initialization
	void Start () {
		sound = GameObject.FindGameObjectWithTag("Sound");
	}
	
	// Update is called once per frame
	void Update () {
	    // for touch input
	    if (Input.touchCount > 0)
	    {
	        foreach (var touch in Input.touches)
	        {
	            gesture currentTouch = detectTouch(touch);
	            Debug.Log(currentTouch);
                Debug.Log(touch.deltaPosition.sqrMagnitude);

                    switch (currentTouch)
                    {
                        case gesture.swipeLeft:
                            transform.Translate(Vector2.left * movement);
                            break;
                        case gesture.swipeRight:
                            transform.Translate(Vector2.right * movement);
                            break;
                        case gesture.tap:
                            shoot();
                            break;
                        default:
                            break;
                    }
            }
	           
	           
        }
	    

        // keyboard input
        if (Input.GetKeyDown(KeyCode.Space))
        {
                shoot();   
        }
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > leftBoundaries)
        {
            transform.Translate(Vector2.left * movement);
        }

        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x <= rightBoundaries)
        {
            transform.Translate(Vector2.right * movement);
        }

        
    }

    private gesture detectTouch(Touch t)
    {
        if (t.deltaPosition.sqrMagnitude > deadzone)
            if (t.deltaPosition.x < 0)
                return gesture.swipeLeft;
        if (t.deltaPosition.x > 0)
            return gesture.swipeRight;

        else return gesture.tap;
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
