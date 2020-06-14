using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class oscillator : MonoBehaviour
{
    float timecounter = 0;

    float speed;
    float width;
    float height;

    // Start is called before the first frame update
    void Start()
    {
        speed = 200;
        width = 50;
        height = 40;

    }

    // Update is called once per frame
    void Update()
    {
        timecounter += Time.deltaTime*speed;

        float x = Mathf.Cos (timecounter) * width;
        float y = Mathf.Sin(timecounter) * height;
        float z = 0;

        transform.position = new Vector3(x, y, z);
        
    }
}
