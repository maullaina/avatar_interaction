using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ok_seven : MonoBehaviour
{
    public GameObject cube7;
    public Material Material1;


    void Update()
    {
        Debug.Log("Score: " + touch_destroy_RUp.ScoreValue);

        if (touch_destroy_RUp.ScoreValue == 30)
        {

            cube7.GetComponent<MeshRenderer>().material = Material1;
        }

    }
}