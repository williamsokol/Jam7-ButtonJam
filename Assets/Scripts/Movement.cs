using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform bulge;
    public float speed, turnSpeed;

    float angle;
    private Quaternion q;
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //rb.AddForce(new Vector2(0,100));
    }

    // Update is called once per frame
    void Update()
    {
        //if button push move in alinment to bulge
        if(Input.GetButtonDown("button")){
            Move();
            
        }
    }

    public void Move(){
        rb.velocity = Vector3.zero;
        Vector2 vectorToTarget = transform.position - bulge.position; 
        angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        q = Quaternion.AngleAxis(angle+90, Vector3.forward);
        
        //transform.rotation =  q;
        rb.AddForce(vectorToTarget * -(speed));
        
    }
    public void FixedUpdate(){
        transform.rotation = Quaternion.Slerp(transform.rotation,q, turnSpeed);
    }
}
