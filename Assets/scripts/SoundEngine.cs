using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class SoundEngine : MonoBehaviour
{
    private AudioSource[] _audioSources;
    public AudioClip[] sound;

    public float pitchLowRange;
    public float pitchHighRange;
    public float volumeLowRange;
    public float volumeHighRange;

    public enum Sound
    {
        Lasershot,
        Explosion,
        PowerUp
    };

    // Use this for initialization
    void Start()
    {
     

        
        _audioSources = gameObject.GetComponents<AudioSource>();
    }

    void playSound(Sound sound)
    {

        switch (sound)
        {
            case Sound.Lasershot:
               _audioSources[0].PlayOneShot(this.sound[0], 1f);
                break;
            case Sound.Explosion:
                _audioSources[1].PlayOneShot(this.sound[1], 1f);
                break;
            case Sound.PowerUp:
                _audioSources[2].PlayOneShot(this.sound[0], 1f);
                break;
        }
    }
}
