using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyKillScript : MonoBehaviour
{
    private GameObject audio;

    public void killGameObject()
    {
        //Debug.Log("Enemy killed by bullet");
        //SendMessage("removeBullet");
        audio.SendMessage("playSound", SoundEngine.Sound.Explosion);
        GameObject.Destroy(gameObject);
    }

	// Use this for initialization
	void Start ()
	{
	    audio = GameObject.FindWithTag("Sound");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
