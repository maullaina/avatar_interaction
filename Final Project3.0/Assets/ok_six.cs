using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ok_six : MonoBehaviour
{
    public GameObject cube6;
    public Material Material1;

    void Update()
    {
        int totalscore = touch_destroy_RUp.ScoreValue + touch_destroy_UpL.ScoreValue + touch_destroy_BotR.ScoreValue + touch_destroy_BotL.ScoreValue;

        Debug.Log("Score: " + totalscore);

        if (totalscore == 25)
        {

            cube6.GetComponent<MeshRenderer>().material = Material1;
        }

    }
}