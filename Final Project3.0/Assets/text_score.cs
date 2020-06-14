using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text_score : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;
    void Start()
    {
        print("text");
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score:" + scoreValue;
    }
}
