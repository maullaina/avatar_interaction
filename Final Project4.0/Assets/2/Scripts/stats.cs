using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class stats : MonoBehaviour
{
    public Text winText;

    private float totalTime;

    public static int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        winText.text = "";
        totalTime = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(ok7.done == false && totalTime<3){
            totalTime += Time.deltaTime;
            winText.text = "Ready...\n\n" + (-Math.Floor(totalTime-3));
        }
        if(ok7.done == false && totalTime>=3){
            totalTime += Time.deltaTime;
            winText.text = "GO!\n\nCurrent Time:\n" + Math.Round(totalTime-3,2);
        }
        if(ok7.done == true){
            winText.text = "Accuracy:\n" + count + "/7\n\nTime:\n" + Math.Round(totalTime-3,2);
        }
        //timeText.text = "Current time: " + totalTime + "s";
    }
}