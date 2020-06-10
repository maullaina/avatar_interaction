using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ok_three : MonoBehaviour
{
    public GameObject cube3;
    public Material Material1;


    void Update()
    {
        Debug.Log("Score: " + touch_destroy_RUp.ScoreValue);

        if (touch_destroy_RUp.ScoreValue == 10)
        {

            cube3.GetComponent<MeshRenderer>().material = Material1;
        }

    }
}