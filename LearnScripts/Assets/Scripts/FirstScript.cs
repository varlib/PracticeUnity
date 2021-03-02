using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public GameObject Cube;
    private
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hVal = Input.GetAxis("Horizontal");
        float vVal = Input.GetAxis("Vertical");

        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");

        if (hVal != 0)
        {
            Cube.transform.Translate(hVal, vVal, 0f);
        }

        if (vVal != 0)
        {
            Cube.transform.Translate(hVal, vVal, 0f);
        }

        if (mxVal != 0)
        {
            Cube.transform.Rotate(0f, mxVal, 0);
        }

        if (myVal != 0)
        {
            transform.Translate(myVal, 0f, 0f);
        }
    }
}
