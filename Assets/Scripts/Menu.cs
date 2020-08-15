using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public float camzoom;
    public Animator bulgeInAnimator;
    public Animator fadeInAnimator;
    public GameObject Enemy;

    // Start is called before the first frame update
    public void StartGame()
    {
        
        fadeInAnimator.SetTrigger("GameStarted");
        bulgeInAnimator.SetTrigger("GameStarted");
        Enemy.SetActive(true);
        this.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
