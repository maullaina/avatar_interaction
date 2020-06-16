using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseR : MonoBehaviour
{
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "handR" || other.tag == "handL")
        {
            SceneManager.LoadScene("2");
        }
    }
}