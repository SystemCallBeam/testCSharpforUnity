using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variable : MonoBehaviour
{
    public float coffeetemp = 80.5f;
    float hottemp = 70.0f;
    float coldtemp = 40.0f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            temptest();
        }
        coffeetemp -= Time.deltaTime * 5f;
    }
    void temptest()
    {
        if (coffeetemp > hottemp)
        {
            print("It's too hot.");
        }

        else if (coffeetemp < coldtemp)
        {
            print("It's so cold.");
        }
        else
        {
            print("It's just right.");
        }
    }
    
}
