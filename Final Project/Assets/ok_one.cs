using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ok_one : MonoBehaviour
{
    public GameObject cube1;
    public Material Material1;
   

    private bool ok1 = false;

    void Update()
    {
        Debug.Log("Score: " + touch_destroy_RUp.ScoreValue);

        if (touch_destroy_RUp.ScoreValue == 1)
        {

            cube1.GetComponent<MeshRenderer>().material = Material1;
        }
        
    }
}

