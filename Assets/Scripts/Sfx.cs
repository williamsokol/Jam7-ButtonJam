using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sfx : MonoBehaviour
{

    public AudioSource sfxPlayer;
    public AudioClip[] sounds;
    
    public static Sfx instance;

    void Awake(){
        instance = this;
    }
    

    public void PlaySound(int sound)
    {
        sfxPlayer.clip  = sounds[sound-1];
        sfxPlayer.Play();
    }
}
