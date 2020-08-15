using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Food : MonoBehaviour
{
    public Collider2D backQuad;
    private Vector2 foodSpawnArea;
    public GameObject foodPre;

    public TextMeshProUGUI test;
    static int foodCount = 0;

    public Movement movement;
    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        movement = Movement.instance;
        camera = GameObject.Find("Main Camera").GetComponent<Camera>();
       print(backQuad.bounds.extents.y);
       foodSpawnArea = new Vector2(backQuad.bounds.extents.x,backQuad.bounds.extents.y);
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player"){
            test.text = "Score: " + ++foodCount;

            // make new food
            float x = Random.Range(foodSpawnArea.x,-foodSpawnArea.x);
            float y = Random.Range(foodSpawnArea.y,-foodSpawnArea.y);
            transform.position =  new Vector3(x,y,0); 

            // buff player
            movement.speed += 50;
            StartCoroutine("GrowCamSize");

            //Play Sound
            Sfx.instance.PlaySound(1);
            
        }
    }

    IEnumerator GrowCamSize()
    {
        WaitForSeconds startup = new WaitForSeconds(.01f);
        float oldSize =camera.orthographicSize;
        float newSize = camera.orthographicSize + .1f;;
        float i= 0;
        while(camera.orthographicSize < newSize){
            camera.orthographicSize += .001f;
            //print( Mathf.SmoothDamp(camera.orthographicSize,100, ref i, 1f));
            yield return startup;
        }
        StopCoroutine("GrowCamSize");
    }
}
