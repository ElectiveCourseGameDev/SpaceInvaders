using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletColliderScript : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("collider trigger");

        if (coll.gameObject.tag == "Enemy")
            coll.gameObject.SendMessage("killEnemy");
        }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
