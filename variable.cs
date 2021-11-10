using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variable : MonoBehaviour
{
    public float coffeetemp = 80.0f;
    float hottemp = 70.0f;
    float coldtemp = 40.0f;
    
    private void Start() {
        string[] str = new string[3];
        str[0] = "one";
        str[1] = "two";
        str[2] = "three";

        foreach (string item in str)
        {
            print(item);
        }
        int n = 0;
        for (int i = n; i < 5; i++)
        {
            temptest();
        }
    }
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
