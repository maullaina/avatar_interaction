using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prova : MonoBehaviour
{
    public GameObject sphere;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "hand")
        {
            print("touched");
            text_score.scoreValue += 1;
        }
    }

}