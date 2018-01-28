using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyKillScript : MonoBehaviour
{
    private GameObject audioSound;
    private GameObject HUD;

    public Boolean DebugMode;

    public int KillPoint;

    public void killGameObject()
    {
        if (DebugMode)Debug.Log("Enemy killed by bullet");
        audioSound.SendMessage("playSound", SoundEngine.Sound.Explosion);
        HUD.SendMessage("incrementScore", KillPoint);
        GameObject.Destroy(gameObject);
       
            GameObject KillEffect = Instantiate(Resources.Load("Explosion", typeof(GameObject))) as GameObject;
            KillEffect.transform.position = transform.position;
        

    }

	// Use this for initialization
	void Start ()
	{
        audioSound = GameObject.FindWithTag("Sound");
	    HUD = GameObject.FindGameObjectWithTag("HUD");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
