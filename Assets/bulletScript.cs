﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float step = speed * Time.deltaTime;
        transform.Translate(Vector2.up * step);        
        
        if (transform.position.y > 6 ) // has left the scene
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.SendMessage("removeBullet");

            Destroy(gameObject);
        }
	}

}
