using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killPlayer : MonoBehaviour
{
    private GameObject HUD;

    // Use this for initialization
    void Start()
    {
        HUD = GameObject.FindGameObjectWithTag("HUD");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Enemy")
        {
            Debug.Log("player collision with enemy");
            HUD.SendMessage("decreaseLivesVisible");
        }
        
    }
}