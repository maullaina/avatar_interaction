using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ok_two : MonoBehaviour
{
    public GameObject cube2;
    public Material Material1;


    void Update()
    {
        Debug.Log("Score: " + touch_destroy_RUp.ScoreValue);

        if (touch_destroy_RUp.ScoreValue == 5)
        {

            cube2.GetComponent<MeshRenderer>().material = Material1;
        }

    }
}