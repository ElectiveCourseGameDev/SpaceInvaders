﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HudExtraLives : MonoBehaviour {

    public int lives = 3;

    private GameObject[] extraLives = new GameObject[3];

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < lives; i++)
        {
            extraLives[i] = (GameObject)Resources.Load("ExtraLife");
            extraLives[i].transform.position = new Vector2(4 + i, 4.3f);
        }


    }

    // Update is called once per frame
    void Update() {

    }
} 