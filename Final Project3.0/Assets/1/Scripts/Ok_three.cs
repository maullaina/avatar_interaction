using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ok_three : MonoBehaviour
{
    public GameObject cube3;
    public Material Material1;

    void Update()
    {
        int totalscore = touch_destroy_RUp.ScoreValue + touch_destroy_UpL.ScoreValue + touch_destroy_BotR.ScoreValue + touch_destroy_BotL.ScoreValue;

        Debug.Log("Score: " + totalscore);

        if (totalscore == 10)
        {

            cube3.GetComponent<MeshRenderer>().material = Material1;
        }

    }
}