using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ok_for : MonoBehaviour
{
    public GameObject cube4;
    public Material Material1;


    void Update()
    {
        Debug.Log("Score: " + touch_destroy_RUp.ScoreValue);

        if (touch_destroy_RUp.ScoreValue == 15)
        {

            cube4.GetComponent<MeshRenderer>().material = Material1;
        }

    }
}