using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
    private int score = 0;
    private int hiscore = 0;

    private Text textObject; 
    
        

	// Use this for initialization
	void Start ()
	{
	    textObject = GetComponentInChildren<Text>();
        UpdateText();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void incrementScore(int i)
    {
        score += i;
        UpdateText();
    }

    private void UpdateText()
    {
        textObject.text = "hi-score: " + hiscore + "\n" + "score: " + score;
    }
}
