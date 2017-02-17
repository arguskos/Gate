using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {


    //Initialize
    public AudioSource[] soundArray = new AudioSource[9];


    //Play sound function
    void PlaySound(string soundName)
    {
        for(int i = 0; i < soundArray.Length; i++)
        {
            if (soundArray[i].name == soundName)
            {
                soundArray[i].Play();
            }
        }
    }

    //Loop sound function
    void ToggleLoop(string loopName)
    {
        for (int i = 0; i < soundArray.Length; i++)
        {
            if ((soundArray[i].name == loopName) && (!soundArray[i].isPlaying))
            {
                soundArray[i].Play();
            }

            else if (soundArray[i].name == loopName)
            {
                soundArray[i].Stop();
            }
        }
    }


    //Example of use
    /*void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            PlaySound("Error");
            ToggleLoop("MachineLoop");
        }
    }*/
}
