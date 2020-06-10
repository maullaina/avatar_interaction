using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch_sum3 : MonoBehaviour
{
    private bool touch = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "ankleR")
        {
            print("touched sum");
            touch = true;
        }
        else
        {
            text_score3.scoreValue -= 1;
        }

    }
    void Update()
    {
        if (touch)
        {
            text_score3.scoreValue += 1;
        }

    }
}