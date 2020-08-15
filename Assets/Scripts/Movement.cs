using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform bulge;
    public float speed, turnSpeed;
    public Menu menu;

    float angle;
    private Quaternion q;
    private Rigidbody2D rb;

    public static Movement instance;
    
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
        rb = GetComponent<Rigidbody2D>();
        //rb.AddForce(new Vector2(0,100));
    }

    // Update is called once per frame
    void Update()
    {
        //if button push move in alinment to bulge
        if(Input.GetButtonDown("button")){
            Move();
            menu.StartGame();
        }
    }

    public void Move(){
        //print("test");
        rb.velocity = Vector3.zero;
        Vector2 vectorToTarget = transform.position - bulge.position; 
        angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        q = Quaternion.AngleAxis(angle+90, Vector3.forward);
        
        //transform.rotation =  q;
        rb.AddForce(vectorToTarget * -(speed));

        //playsound
        Sfx.instance.PlaySound(3);
        
    }
    public void FixedUpdate(){
        transform.rotation = Quaternion.Slerp(transform.rotation,q, turnSpeed);
    }
}
