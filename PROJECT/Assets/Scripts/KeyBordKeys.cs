﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBordKeys : MonoBehaviour
{
    public GameObject Portal;
    public GameObject Gameflow;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    Color ColConv(Color col)
    {
        return new Color(col.r / 255.0f, col.g / 255.0f, col.b / 255.0f);
    }
    void Update()
    {
        // gamepad keys
        bool oneZeroButton = Input.GetButton("Side 1 Button 0");//returns true while button is pressed
        bool oneZeroDown = Input.GetButtonDown("Side 1 Button 0");//returns true once when button is pressed
        bool oneZeroUp = Input.GetButtonUp("Side 1 Button 0");// returns true once when button is released

        bool oneOneButton = Input.GetButton("Side 1 Button 1");
        bool oneOneDown = Input.GetButtonDown("Side 1 Button 1");
        bool oneOneUp = Input.GetButtonUp("Side 1 Button 1");

        bool oneTwoButton = Input.GetButton("Side 1 Button 2");
        bool oneTwoDown = Input.GetButtonDown("Side 1 Button 2");
        bool oneTwoUp = Input.GetButtonUp("Side 1 Button 2");

        bool oneThreeButton = Input.GetButton("Side 1 Button 3");
        bool oneThreeDown = Input.GetButtonDown("Side 1 Button 3");
        bool oneThreeUp = Input.GetButtonUp("Side 1 Button 3");

        bool oneFourButton = Input.GetButton("Side 1 Button 4");
        bool oneFourDown = Input.GetButtonDown("Side 1 Button 4");
        bool oneFourUp = Input.GetButtonUp("Side 1 Button 4");

        bool oneFiveButton = Input.GetButton("Side 1 Button 5");
        bool oneFiveDown = Input.GetButtonDown("Side 1 Button 5");
        bool oneFiveUp = Input.GetButtonUp("Side 1 Button 5");

        bool oneSixButton = Input.GetButton("Side 1 Button 6");
        bool oneSixDown = Input.GetButtonDown("Side 1 Button 6");
        bool oneSixUp = Input.GetButtonUp("Side 1 Button 6");

        bool oneSevenButton = Input.GetButton("Side 1 Button 7");
        bool oneSevenDown = Input.GetButtonDown("Side 1 Button 7");
        bool oneSevenUp = Input.GetButtonUp("Side 1 Button 7");

        bool oneEightButton = Input.GetButton("Side 1 Button 8");
        bool oneEightDown = Input.GetButtonDown("Side 1 Button 8");
        bool oneEightUp = Input.GetButtonUp("Side 1 Button 8");

        bool twoEightButton = Input.GetButton("Side 2 Button 8");
        bool twoEightDown = Input.GetButtonDown("Side 2 Button 8");
        bool twoEightUp = Input.GetButtonUp("Side 2 Button 8");

        // PORTAL KEYS
        if (Input.GetKeyDown(KeyCode.Q) || oneEightDown == true)
        //Debug.Log("Sdadsd");
        {
            // if (!Portal.GetComponent<PortalOpener>().GetIsOpen())
            //Portal.GetComponent<PortalOpener>().StartCoroutine("Open", ColConv(new Color(255, 39, 39)));
            Portal.GetComponent<PortalOpener>().Open(ColConv(new Color(216, 39, 39)),1);

        }
        if (Input.GetKeyDown(KeyCode.W) || oneSevenDown == true)
        {
            Portal.GetComponent<PortalOpener>().Open(ColConv(new Color(217, 158, 39)), 2);
        }
        if (Input.GetKeyDown(KeyCode.E) || oneSixDown ==  true)
            Portal.GetComponent<PortalOpener>().Open(ColConv(new Color(172, 236, 43)), 3);


        if (Input.GetKeyDown(KeyCode.A) || oneFiveDown == true)
            Portal.GetComponent<PortalOpener>().Open(ColConv(new Color(33, 152, 33)), 4);

        if (Input.GetKeyDown(KeyCode.S) || oneFourDown == true)
            Portal.GetComponent<PortalOpener>().Open(ColConv(new Color(36, 255, 182)), 5);

        if (Input.GetKeyDown(KeyCode.D) || oneThreeDown == true)
            Portal.GetComponent<PortalOpener>().Open(ColConv(new Color(39, 158, 217)), 6);



        if (Input.GetKeyDown(KeyCode.Z) || oneTwoDown == true)
            Portal.GetComponent<PortalOpener>().Open(ColConv(new Color(34, 34, 122)), 7);
        if (Input.GetKeyDown(KeyCode.X) || oneOneDown == true)
            Portal.GetComponent<PortalOpener>().Open(ColConv(new Color(157, 39, 217)), 8);
        if (Input.GetKeyDown(KeyCode.C) || oneZeroDown == true)
            Portal.GetComponent<PortalOpener>().Open(ColConv(new Color(217, 39, 158)),9);




        if (Input.GetKeyDown(KeyCode.R) || twoEightDown)
            //Debug.Log("sdas");
            Gameflow.GetComponent<Gameflow>().Spawn();



        if (Input.GetKeyUp(KeyCode.Q) ||
            Input.GetKeyUp(KeyCode.W) ||
            Input.GetKeyUp(KeyCode.E) ||

            Input.GetKeyUp(KeyCode.A) ||
            Input.GetKeyUp(KeyCode.S) ||
            Input.GetKeyUp(KeyCode.D) ||

            Input.GetKeyUp(KeyCode.Z) ||
            Input.GetKeyUp(KeyCode.X) ||
            Input.GetKeyUp(KeyCode.C) || 
            oneEightUp || oneSevenUp || oneSixUp || oneFiveUp || oneFourUp || oneThreeUp || oneTwoUp || oneOneUp || oneZeroUp
            )
        //if (Portal.GetComponent<PortalOpener>().GetIsOpen())
        //Portal.GetComponent<PortalOpener>().StartCoroutine("Close");
        {
            Portal.GetComponent<PortalOpener>().Close();
        }
    }
}
