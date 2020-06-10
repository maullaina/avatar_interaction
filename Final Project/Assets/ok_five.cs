using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ok_five : MonoBehaviour
{
    public GameObject cube5;
    public Material Material1;


    void Update()
    {
        Debug.Log("Score: " + touch_destroy_RUp.ScoreValue);

        if (touch_destroy_RUp.ScoreValue == 20)
        {

            cube5.GetComponent<MeshRenderer>().material = Material1;
        }

    }
}