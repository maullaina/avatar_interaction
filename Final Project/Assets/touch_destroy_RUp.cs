using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch_destroy_RUp: MonoBehaviour
{
    public GameObject sphere;
    public Material Material1;
    public Material Material2;
    public Material Material3;
    private bool wrong = false;
    private bool Ok = false;
    public static int ScoreValue = 0;

    void Update()
    {
        if (wrong)
        {
            sphere.GetComponent<MeshRenderer>().material = Material1;
        }
        if (Ok)
        {
            sphere.GetComponent<MeshRenderer>().material = Material3;
        }
        else
        {
            sphere.GetComponent<MeshRenderer>().material = Material2;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "handR")
        {
            print("touched");
            goOk();
        }
        if (other.tag == "handL")
        {
            print("touched2");
            goWrong();

        }
        else
        {
            sphere.GetComponent<MeshRenderer>().material = Material2;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "handL")
        {
            returnWrong();
        }
        if (other.tag == "handR")
        {
            returnOk();
        }
        else
        {
            sphere.GetComponent<MeshRenderer>().material = Material2;
        }

    }
    public void returnWrong()
    {
        wrong = false;
    }
    public void goWrong()
    {
        wrong = true;
    }
    public void returnOk()
    {
        Ok = false;
    }
    public void goOk()
    {
        Ok = true;
        ScoreValue = ScoreValue + 1;
        Debug.Log("score"+ ScoreValue);
    }
}


