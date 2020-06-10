using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube1 : MonoBehaviour
{
    public GameObject firstsph;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "handR")
        {
            print("touched");
            Destroy(firstsph);
        }
    }

}


