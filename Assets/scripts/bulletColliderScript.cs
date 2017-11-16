using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletColliderScript : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("collider trigger");

        // hits enemy?
        if (coll.gameObject.tag == "Enemy")

            // tell enemy to kill itself
            coll.gameObject.SendMessage("killEnemy");

            // destroy bullet
            Destroy(gameObject);
        }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
