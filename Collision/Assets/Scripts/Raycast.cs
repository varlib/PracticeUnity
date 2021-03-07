using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxis("Mouse X");
        float dirY = Input.GetAxis("Mouse Y");
        transform.Rotate(dirX, dirY, 0);
        CheckForRaycast();
    }

    private void CheckForRaycast()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.distance < 7)
            {
                print(hit.distance + " destroy");
                Destroy(hit.collider.gameObject);
            }
            else
            {
                print("Далековато!");
            }
        }
    }
}
