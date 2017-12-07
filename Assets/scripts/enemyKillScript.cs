using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyKillScript : MonoBehaviour
{
    private GameObject audio;
    private GameObject HUD;

    public int KillPoint;

    public void killGameObject()
    {
        Debug.Log("Enemy killed by bullet");
        audio.SendMessage("playSound", SoundEngine.Sound.Explosion);
        HUD.SendMessage("incrementScore", KillPoint);
        GameObject.Destroy(gameObject);
       
    }

	// Use this for initialization
	void Start ()
	{
        audio = GameObject.FindWithTag("Sound");
	    HUD = GameObject.FindGameObjectWithTag("HUD");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
