using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyKillScript : MonoBehaviour {

    public void killEnemy()
    {
        //Debug.Log("Enemy killed by bullet");
        //SendMessage("removeBullet");
        GameObject.Destroy(gameObject);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
