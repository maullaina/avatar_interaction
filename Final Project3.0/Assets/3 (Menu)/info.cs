using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class info : MonoBehaviour
{
    public Text w;

    // Start is called before the first frame update
    void Start()
    {
        w.text = "Main Menu\n\nChoose today's activity!";
    }
}