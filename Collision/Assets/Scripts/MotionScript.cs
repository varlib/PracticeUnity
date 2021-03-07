using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xPositio = Input.GetAxis("Horizontal")/2;
        float yPosition = Input.GetAxis("Vertical")/2;
        transform.Translate(xPositio, yPosition, 0);
    }
}
