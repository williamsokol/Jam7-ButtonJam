﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulgeOrbit : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = player.position;
        transform.Rotate(0,0,5);
    }
}
