using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch_sum4 : MonoBehaviour
{
    private bool touch = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "ankleL")
        {
            print("touched sum");
            touch = true;
        }
        else
        {
            text_score4.scoreValue -= 1;
        }

    }
    void Update()
    {
        if (touch)
        {
            text_score4.scoreValue += 1;
        }

    }
}