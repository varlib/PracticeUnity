﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        print(gameObject.name + " Enter!");
    }

    private void OnTriggerStay(Collider other)
    {
        print(gameObject.name + " Stay!");
    }

    private void OnTriggerExit(Collider other)
    {
        print(gameObject.name + " Exit!");
    }
}
