using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEngine : MonoBehaviour {

    public AudioClip[] sounds = new AudioClip[5];

    private AudioSource[] audioSources = new AudioSource[5];

    private AudioClip audioClip;

    // Use this for initialization
    void Start () {
        for (int i = 0; i < sounds.Length; i++)
        {
            AudioSource audioSource = new AudioSource();
            audioSource.clip = sounds[i];
            audioSources[i] = audioSource;
        }

	}
	
	void shoot()
    {
        
    }
}
