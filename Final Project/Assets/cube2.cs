using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube2 : MonoBehaviour
{
    public Transform secondcube;
    public Vector3 rotationSpeed;
    private bool touch = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "handL")
        {
            print("touched ROTATE");
            touch = true;
        }
    }
    void Update()
    {
        if (touch)
        {
            secondcube.Rotate(rotationSpeed * Time.deltaTime);
        }
    }
}