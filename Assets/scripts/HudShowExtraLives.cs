using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HudShowExtraLives : MonoBehaviour {

    public int lives = 3;

    public GameObject[] ExtraLives = new GameObject[3];

    // Use this for initialization
    void Start()
    {
        /*
        for (int i = 0; i < lives; i++)
        {
            ExtraLives[i] = (GameObject)Resources.Load("ExtraLife");
            ExtraLives[i].transform.position = new Vector2(4 + i, 4.3f);
        }
        */

    }

    // Update is called once per frame
    void Update() {
        
    }

    public void decreaseLivesVisible()
    {
        // hide a extralife
        lives--;
        ExtraLives[lives].SetActive(false);
        //ExtraLives[lives].SetActive(false);
    }

    public void increaseLivesVisible()
    {
        ExtraLives[lives].SetActive(true);
        lives++;
    }
} 
