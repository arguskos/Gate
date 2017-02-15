using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour {

    public Camera[] cameras = new Camera[4];
    public byte currCam = 1;
    public GameObject shrinker;

	// Use this for initialization
	void Start () {
        cameras[0].enabled = true;
        cameras[1].enabled = false;
        cameras[2].enabled = false;
        cameras[3].enabled = false;
    }

	
	// Update is called once per frame
	void Update ()
    {
        #region Button Input
        #region Button bools

        //Constructor side
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

        //Supervisor side
        bool twoZeroButton = Input.GetButton("Side 2 Button 0");//returns true while button is pressed
        bool twoZeroDown = Input.GetButtonDown("Side 2 Button 0");//returns true once when button is pressed
        bool twoZeroUp = Input.GetButtonUp("Side 2 Button 0");// returns true once when button is released

        bool twoOneButton = Input.GetButton("Side 2 Button 1");
        bool twoOneDown = Input.GetButtonDown("Side 2 Button 1");
        bool twoOneUp = Input.GetButtonUp("Side 2 Button 1");

        bool twoTwoButton = Input.GetButton("Side 2 Button 2");
        bool twoTwoDown = Input.GetButtonDown("Side 2 Button 2");
        bool twoTwoUp = Input.GetButtonUp("Side 2 Button 2");

        bool twoThreeButton = Input.GetButton("Side 2 Button 3");
        bool twoThreeDown = Input.GetButtonDown("Side 2 Button 3");
        bool twoThreeUp = Input.GetButtonUp("Side 2 Button 3");

        bool twoFourButton = Input.GetButton("Side 2 Button 4");
        bool twoFourDown = Input.GetButtonDown("Side 2 Button 4");
        bool twoFourUp = Input.GetButtonUp("Side 2 Button 4");

        bool twoFiveButton = Input.GetButton("Side 2 Button 5");
        bool twoFiveDown = Input.GetButtonDown("Side 2 Button 5");
        bool twoFiveUp = Input.GetButtonUp("Side 2 Button 5");

        bool twoSixButton = Input.GetButton("Side 2 Button 6");
        bool twoSixDown = Input.GetButtonDown("Side 2 Button 6");
        bool twoSixUp = Input.GetButtonUp("Side 2 Button 6");

        bool twoSevenButton = Input.GetButton("Side 2 Button 7");
        bool twoSevenDown = Input.GetButtonDown("Side 2 Button 7");
        bool twoSevenUp = Input.GetButtonUp("Side 2 Button 7");

        bool twoEightButton = Input.GetButton("Side 2 Button 8");
        bool twoEightDown = Input.GetButtonDown("Side 2 Button 8");
        bool twoEightUp = Input.GetButtonUp("Side 2 Button 8");

        #endregion

        #region Button outputs

        //ouput constructor
        #region oneZero
        if (oneZeroButton == true)
        {
            Debug.Log("oneZero : pressed and held");
        }
        if (oneZeroDown == true)
        {
            Debug.Log("oneZero : pressed once");
        }
        if (oneZeroUp == true)
        {
            Debug.Log("oneZero : released");
        }
        #endregion

        #region oneOne
        if (oneOneButton == true)
        {
            Debug.Log("oneOne : pressed and held");
        }
        if (oneOneDown == true)
        {
            Debug.Log("oneOne : pressed once");
        }
        if (oneOneUp == true)
        {
            Debug.Log("oneOne : released");
        }
        #endregion

        #region oneTwo
        if (oneTwoButton == true)
        {
            Debug.Log("oneTwo : pressed and held");
        }
        if (oneTwoDown == true)
        {
            Debug.Log(" oneTwo : pressed once");
        }
        if (oneTwoUp == true)
        {
            Debug.Log("oneTwo : released");
        }
        #endregion

        #region oneThree
        if (oneThreeButton == true)
        {
            Debug.Log("oneThree : pressed and held");
        }
        if (oneThreeDown == true)
        {
            Debug.Log(" oneThree : pressed once");
        }
        if (oneThreeUp == true)
        {
            Debug.Log("oneThree : released");
        }
        #endregion

        #region oneFour
        if (oneFourButton == true)
        {
            Debug.Log("oneFour : pressed and held");
        }
        if (oneFourDown == true)
        {
            Debug.Log(" oneFour : pressed once");
        }
        if (oneFourUp == true)
        {
            Debug.Log("oneFour : released");
        }
        #endregion

        #region oneFive
        if (oneFiveButton == true)
        {
            Debug.Log("oneFive : pressed and held");
        }
        if (oneFiveDown == true)
        {
            Debug.Log(" oneFive : pressed once");
        }
        if (oneFiveUp == true)
        {
            Debug.Log("oneFive : released");
        }
        #endregion

        #region oneSix
        if (oneSixButton == true)
        {
            Debug.Log("oneSix : pressed and held");
        }
        if (oneSixDown == true)
        {
            Debug.Log(" onesix : pressed once");
        }
        if (oneSixUp == true)
        {
            Debug.Log("oneSix : released");
        }
        #endregion

        #region oneSeven
        if (oneSevenButton == true)
        {
            Debug.Log("oneSeven : pressed and held");
        }
        if (oneSevenDown == true)
        {
            Debug.Log(" oneSeven : pressed once");
        }
        if (oneSevenUp == true)
        {
            Debug.Log("oneSeven : released");
        }
        #endregion

        #region oneEight
        if (oneEightButton == true)
        {
            Debug.Log("oneEight : pressed and held");
        }
        if (oneEightDown == true)
        {
            Debug.Log(" oneEight : pressed once");
        }
        if (oneEightUp == true)
        {
            Debug.Log("oneEight : released");
        }
        #endregion

        //ouput constructor
        #region down
        if (twoZeroButton == true)
        {
            //Debug.Log("twoZero : pressed and held");
            Debug.Log("Down");
        }
        if (twoZeroDown == true)
        {
            //Debug.Log("twoZero : pressed once");
        }
        if (twoZeroUp == true)
        {
            //Debug.Log("twoZero : released");
        }
        #endregion

        #region right
        if (twoOneButton == true)
        {
            //Debug.Log("twoOne : pressed and held");
            Debug.Log("Right");
        }
        if (twoOneDown == true)
        {
            //Debug.Log("twoOne : pressed once");
        }
        if (twoOneUp == true)
        {
            //Debug.Log("twoOne : released");
        }
        #endregion

        #region action button 1
        if (twoTwoButton == true)
        {
            //Debug.Log("twoTwo : pressed and held");
        }
        if (twoTwoDown == true)
        {
            //Debug.Log(" twoTwo : pressed once");
            buttonControl("act1");

        }
        if (twoTwoUp == true)
        {
            //Debug.Log("twoTwo : released");
        }
        #endregion

        #region left
        if (twoThreeButton == true)
        {
            //Debug.Log("twoThree : pressed and held");
            Debug.Log("Left");
        }
        if (twoThreeDown == true)
        {
            //Debug.Log(" twoThree : pressed once");
        }
        if (twoThreeUp == true)
        {
            //Debug.Log("twoThree : released");
        }
        #endregion

        #region up
        if (twoFourButton == true)
        {
            //Debug.Log("twoFour : pressed and held");
            Debug.Log("Up");
        }
        if (twoFourDown == true)
        {
            //Debug.Log(" twoFour : pressed once");
        }
        if (twoFourUp == true)
        {
            //Debug.Log("oneFour : released");
        }
        #endregion

        #region action button 2
        if (twoFiveButton == true)
        {
            //Debug.Log("twoFive : pressed and held");
        }
        if (twoFiveDown == true)
        {
            //Debug.Log(" twoFive : pressed once");
            buttonControl("act2");

        }
        if (twoFiveUp == true)
        {
            //Debug.Log("twoFive : released");
        }
        #endregion

        #region Camera toggle next
        if (twoSixButton == true)
        {
            //Debug.Log("twoSix : pressed and held");
        }
        if (twoSixDown == true)
        {
            //Debug.Log(" twosix : pressed once");
            Debug.Log("Toggle camera next");
            cameraControl("next");
        }
        if (twoSixUp == true)
        {
            //Debug.Log("twoSix : released");
        }
        #endregion

        #region camera toggle back  
        if (twoSevenButton == true)
        {
            //Debug.Log("twoSeven : pressed and held");
        }
        if (twoSevenDown == true)
        {
            //Debug.Log(" twoSeven : pressed once");
            Debug.Log("Toggle camera back");
            cameraControl("back");
        }
        if (twoSevenUp == true)
        {
            //Debug.Log("twoSeven : released");
        }
        #endregion

        #region Light toggle
        if (twoEightButton == true)
        {
            //Debug.Log("twoEight : pressed and held");
        }
        if (twoEightDown == true)
        {
            //Debug.Log(" twoEight : pressed once");
            Debug.Log("turn on/off light");
        }
        if (twoEightUp == true)
        {
            //Debug.Log("twoEight : released");
        }
        #endregion

        #endregion
        #endregion
    }

    private void cameraControl(string input) 
    {
        byte newCam = currCam;
        if (input == "next")
        {
            if (currCam >= 3)
            {
                newCam = 0;
            }
            else
            {
                newCam++;
            }
        }
        else if (input == "back")
        {
            if (currCam <= 0)
            {
                newCam = 3;
            }
            else
            {
                newCam--;
            }
        }
        cameras[currCam].enabled = false;
        cameras[newCam].enabled = true;
        currCam = newCam;
    }
    private void buttonControl(string input) 
    {
        switch (currCam)
        {
            case 0 :
                // send to main camera
                break;
            case 1 :
                // send to shrinkcam
                messageSender(input,shrinker);
                break;
            case 2 :
                // send to ..
                break;
            case 3 :
                //send to ...
                break;
            default:
                break;
        }
    }
    private void messageSender(string mssg, GameObject receiver) 
    {
        receiver.SendMessage("buttonPress",mssg);
    }

}
