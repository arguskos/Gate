using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public AudioSource[] sounds = new AudioSource[10];
	
	// Update is called once per frame
	void Update () {
		
	}

    void PlaySound(string soundName)
    {
        for(int i = 0; i < sounds.Length; i++)
        {
            //Do Nothing
        }
    }
}
