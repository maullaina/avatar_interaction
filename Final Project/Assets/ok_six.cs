using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ok_six : MonoBehaviour
{
    public GameObject cube6;
    public Material Material1;


    void Update()
    {
        Debug.Log("Score: " + touch_destroy_RUp.ScoreValue);

        if (touch_destroy_RUp.ScoreValue == 25)
        {

            cube6.GetComponent<MeshRenderer>().material = Material1;
        }

    }
}