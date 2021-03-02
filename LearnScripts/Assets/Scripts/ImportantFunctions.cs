using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportantFunctions : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        for (int i=1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                print($"Это число {i} кратно 3");
            }else if (i % 5 == 0)
            {
                print($"Это число {i} кратно 5");
            }
            else
            {
                print("Программирование это шик и блеск!");
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
