using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube4 : MonoBehaviour
{
    public GameObject forthcube;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "footR")
        {
            print("touched");
            Destroy(forthcube, .5f);
        }
    }

}