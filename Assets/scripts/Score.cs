using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
    private int score = 0;
    private int hiscore;

    private Text textObject; 
    
        

	// Use this for initialization
	void Start ()
	{
	    if (PlayerPrefs.HasKey("hiscore"))
	    {
	        hiscore = PlayerPrefs.GetInt("hiscore");
	    }
	    else
	    {
	        hiscore = 1000;
	    }

	    textObject = GetComponentInChildren<Text>();
        UpdateText();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void incrementScore(int i)
    {
        score += i;
        if (score > hiscore) hiscore = score;
        UpdateText();
    }

    public int getScore()
    {
        return score;
    }

    private void UpdateText()
    {
        textObject.text = "hi-score: " + hiscore + "\n" + "score: " + score;
    }
}
