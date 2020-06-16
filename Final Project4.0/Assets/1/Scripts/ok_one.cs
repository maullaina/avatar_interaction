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
        int totalscore = touch_destroy_RUp.ScoreValue + touch_destroy_UpL.ScoreValue + touch_destroy_BotR.ScoreValue + touch_destroy_BotL.ScoreValue;
        Debug.Log("Score: " + totalscore);

        if (totalscore == 1)
        {

            cube1.GetComponent<MeshRenderer>().material = Material1;
        }
        
    }
}

