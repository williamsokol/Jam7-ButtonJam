using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource music;
    // Start is called before the first frame update
    public void StopMusic(){
        music.volume = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
