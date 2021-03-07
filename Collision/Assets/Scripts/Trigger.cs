using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + " enter");
    }

    private void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name + " stray");
    }
    private void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + " exit");
        //Destroy(other.gameObject);
        //other.gameObject.transform.Translate(0f, 1f, -5f);
        //Instantiate(other.gameObject, new Vector3(0f,1f-5f), Quaternion.identity);
    }



}