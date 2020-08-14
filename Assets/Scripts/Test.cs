using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject lastBit, firstBit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         
        Vector3 thing = Vector3.Lerp (lastBit.transform.position, firstBit.transform.position,.1f);
        Vector3 thin = Vector3.Lerp (lastBit.transform.eulerAngles, firstBit.transform.eulerAngles,.9f);
        
        lastBit.transform.position = thing;
        lastBit.transform.rotation = Quaternion.Slerp(lastBit.transform.rotation,firstBit.transform.rotation, .1f);
        //print(lastBit.transform.rotation.eulerAngles+" "+firstBit.transform.rotation.eulerAngles);
        //lastBit.transform.Rotate(0,0,thin.z);
    }
}
