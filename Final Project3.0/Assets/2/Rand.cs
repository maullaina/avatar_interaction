using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Rand : MonoBehaviour
{
    AudioSource source;
    public AudioClip audio1;
    public AudioClip audio2;
    public AudioClip audio3;
    public AudioClip audio4;

    public static int id;

    public static int succ = 0;

    public static bool finished = false;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(3);
        play();
    }

    void Update()
    {
    	if (finished == true && ok7.done == false)
    	{
    		play();
    		finished = false;
    	}
    }

    void play()
    {
    	AudioSource source = GetComponent<AudioSource>();

    	System.Random rnd = new System.Random();

		id = rnd.Next(1,5);

		if(id == 1){
			source.clip = audio1;
			source.Play(0);
		}
		if(id == 2){
			source.clip = audio2;
			source.Play(0);
		}
		if(id == 3){
			source.clip = audio3;
			source.Play(0);
		}
		if(id == 4){
			source.clip = audio4;
			source.Play(0);
		}
    }
}
