﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class schrinkmachine : MonoBehaviour {

    private bool objectInSchrinker = false;
    private Collider toShrinkObj;
    private byte timesShrunk = 0;
    private byte TimesGrown = 0;
    private bool beingtampered = false;
    public SoundManager SundManager;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        // if (Input.anyKeyDown == true)
        //{
        //  Debug.Log("ahahahaha");
        //buttonPress("act2");
        //}
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Machinable"|| other.tag == "Object")
        {
            toShrinkObj = other;
            objectInSchrinker = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Machinable" || other.tag == "Object")
        {
            objectInSchrinker = false;
            timesShrunk = 0;
            TimesGrown = 0;
        }
    }
    void buttonPress(string input) 
    {
        if (objectInSchrinker ==  true && beingtampered == false)
        {
            Debug.Log("woop i git it");
            
            if (input == "act1")
            {
                //toShrinkObj.transform.localScale = toShrinkObj.transform.localScale * 1.0F;
                //grow
                SundManager.PlaySound(SoundManager.Sound.Button);
                StartCoroutine(sizeShange("big"));
            }
            else if(input == "act2")
            {
                //toShrinkObj.transform.localScale = toShrinkObj.transform.localScale / 2;  
                //shrink
                SundManager.PlaySound(SoundManager.Sound.Button);
                StartCoroutine(sizeShange("small"));
            }
        }
        else
        {
            Debug.Log("put it inside meh");   
            //aha
        }
        
    }
    IEnumerator sizeShange(string desiredSize)
    {
        //This is a coroutine
        beingtampered = true;
        if (desiredSize == "big" && TimesGrown < 2)
        {
            for (int i = 0; i < 20; i++)
            {
                //Upgrade
                SundManager.PlaySound(SoundManager.Sound.Upgrade);
                toShrinkObj.transform.localScale = toShrinkObj.transform.localScale * 1.02F;
                yield return 0;
            }
            if (timesShrunk >= 1)
            {
                timesShrunk--;
            }
            else
            {
                TimesGrown++;   
            }
        }
        else if (desiredSize == "small" && timesShrunk < 2)
        {
            for (int i = 0; i < 20; i++)
            {
                SundManager.PlaySound(SoundManager.Sound.Upgrade);
                toShrinkObj.transform.localScale = toShrinkObj.transform.localScale / 1.02F;
                yield return 0;
            }
            if (TimesGrown >= 1)
            {
                TimesGrown--;
            }
            else
            {
                timesShrunk++;
            }
        }
        beingtampered = false;


          //Wait one frame

        //DoSomethingElse();
    }
}
