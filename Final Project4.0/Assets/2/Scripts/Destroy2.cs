﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy2 : MonoBehaviour
{
    public GameObject sphere;
    public Material Material1;
    public Material Material2;
    public Material Material3;
    private bool wrong = false;
    private bool Ok = false;

    public float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (wrong)
        {
            sphere.GetComponent<MeshRenderer>().material = Material1;
        }
        if (Ok)
        {
            sphere.GetComponent<MeshRenderer>().material = Material3;
        }
        if (wrong==false && Ok==false)
        {
            sphere.GetComponent<MeshRenderer>().material = Material2;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (timer > 1)
        {
            timer = 0;
            if ( (other.tag == "handR" || other.tag == "handL") && Rand.id == 2)
            {
                goOk();
            }
            if ( (other.tag == "handR" || other.tag == "handL") && Rand.id != 2)
            {
                goWrong();
            }
            else
            {
                sphere.GetComponent<MeshRenderer>().material = Material2;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        wrong = false;
        Ok = false;
    }

    public void goWrong()
    {
        wrong = true;
        Rand.succ = -1;
    }

    public void goOk()
    {
        Ok = true;
        Rand.succ = 1;
    }
}