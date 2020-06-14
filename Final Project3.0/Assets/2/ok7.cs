using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ok7 : MonoBehaviour
{
    public GameObject cube1;
    public Material Material1;
	public Material Material2;

	public static bool done = false;

    void Update()
    {
    	if(ok6.done == true)
    	{
	    	if (Rand.succ == 1 && done == false)
	        {
	            cube1.GetComponent<MeshRenderer>().material = Material1;
	            Rand.succ = 0;
	        	done = true;
	        	Rand.finished = true;
	        	stats.count++;
	        }
	        else if (Rand.succ == -1 && done == false)
	        {
	            cube1.GetComponent<MeshRenderer>().material = Material2;
	            Rand.succ = 0;
	        	done = true;
	        	Rand.finished = true;
	        }
    	}
    }
}
