using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch_destroy_BotL : MonoBehaviour
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
        print("fuck");
        if (wrong)
        {
            sphere.GetComponent<MeshRenderer>().material = Material1;
        }
        if (Ok)
        {
            sphere.GetComponent<MeshRenderer>().material = Material3;
        }
        if (wrong == false && Ok == false)
        {
            sphere.GetComponent<MeshRenderer>().material = Material2;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "footL")
        {
            print("touched");
            goOk();
        }
        if (other.tag == "footR")
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
        if (other.tag == "footR")
        {
            returnWrong();
        }
        if (other.tag == "footL")
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
        Debug.Log("score" + ScoreValue);
    }
}



