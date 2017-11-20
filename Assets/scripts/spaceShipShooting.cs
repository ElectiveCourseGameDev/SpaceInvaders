using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceShipShooting : MonoBehaviour {

    public float shootingAcuracy = 1;
    public float coolDown = 1;
    private float nextShot;
    private GameObject player;
    // Use this for initialization
	void Start () {
        nextShot = Time.fixedTime;
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {

        // only visible in the scene - Not in the game! windoww
	    Debug.DrawRay(transform.position, Vector2.down * 10, Color.red);

        /*
        if (isCoolDown())
        {
            if (hasClearSight())
            {
                instansiateBullet();
            }
        }*/
	    hasClearSight();
	}

    private void hasClearSight()
    {
        /*
        //if player is beneath the spaceship
        if (Mathf.Abs(player.transform.position.x - transform.position.x) <= shootingAcuracy)
        {
            // if spaceship has a clear sight
            RaycastHit2D hits = Physics2D.Raycast(transform.position, Vector2.down, 10);
            if (hits.collider != null)
            {
                if (hits.collider.gameObject.tag == "Player")
                {
                    Debug.Log("clear sight!");
                    return true;
                }
            }
            Debug.Log("somthing is in the way?");
        }
        
        return false;
        */

        //Debug.Log(Physics2D.Raycast(transform.position, Vector2.down).collider.gameObject.tag);
        
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
        bullet.GetComponent<bulletScript>().direction = bulletScript.Direction.DOWN;
        bullet.GetComponent<bulletScript>().owner = gameObject;
    }
}
