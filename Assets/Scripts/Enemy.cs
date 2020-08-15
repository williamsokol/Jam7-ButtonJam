using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    public Animator menu;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player"){
          
            GameOver();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 vectorToTarget = transform.position - player.transform.position; 
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle+90, Vector3.forward);

        transform.rotation = q;

        transform.position -= new Vector3(vectorToTarget.x/100,vectorToTarget.y/100,0);
    }

    public void GameOver(){
        //Time.timeScale = 0f;
        Destroy(Movement.instance.gameObject);
        menu.SetTrigger("gameOver");
        
        //Play Sound
        Sfx.instance.PlaySound(2);

    }
}
