using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch_sum2 : MonoBehaviour
{
    private bool touch = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "WristL")
        {
            print("touched sum");
            touch = true;
        }
        else
        {
            text_score2.scoreValue -= 1;
        }

    }
    void Update()
    {
        if (touch)
        {
            print("touchL");
            text_score2.scoreValue += 1;
        }

    }
}