using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch_sum : MonoBehaviour
{
    public GameObject cube1;
    private bool touch = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "hand")
        {
            print("touched sum");
            touch = true;
        }
        else
        {
            text_score.scoreValue -= 1;
        }
       
    }
    void Update()
    {
        if (touch)
        {
            text_score.scoreValue += 1;
        }

    }
}