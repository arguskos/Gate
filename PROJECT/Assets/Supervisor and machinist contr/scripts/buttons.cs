using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttons : MonoBehaviour {

    public Camera[] cameras = new Camera[5];
    public byte currCam = 3;
    public GameObject shrinker;
    public GameObject packer;
    public GameObject box;
    public Light light1;
    public Light light2;
    public Light light3;
    public Light allLight;
    public Vector3 boxPos = new Vector3(0.34F, 2.3F, 0.79F);
    public Vector3 boxRot = new Vector3(-90,0,0);
    private bool cameraInUse = false;
    private bool inviro = true;
    public float gravity = -1;
    private float gravDegradeSpeed = 0.00125F;
    private float gravUp = 0.25F;
    public float lightQuali = 1;
    private float lightDegradeSpeed = 0.000175F;
    private float lightUp = 0.10F;
    private bool gravSelected = false;
    private bool lightSelected = false;
    private bool resourceSelected = false;
    private bool leftHeld = false;
    private bool rightHeld = false;

    public SoundManager SundManager;
    public GameObject Bar1;

    public GameObject Bar2;
    // Use this for initialization
    void Start () {
        cameras[0].enabled = false;
        cameras[1].enabled = false;
        cameras[2].enabled = false;
        cameras[3].enabled = true;
        cameras[4].enabled = false;
        StartCoroutine(enviro());
    }

	
	// Update is called once per frame
	void Update ()
    {
        if (0.45 < lightQuali && lightQuali <= 0.75 )
        {
            Debug.Log("licht 1 gespronge");
            light1.enabled = false;
        }
        else if(0 < lightQuali && lightQuali <= 0.45)
        {
            Debug.Log("light 2 gespronge");
            light2.enabled = false;
        }
        else if(lightQuali <= 0)
        {
            Debug.Log("light 3 gespronge doe nu toch iet");
            light3.enabled = false;
            allLight.enabled = false;
        }


        if (Input.GetKeyDown("a"))
        {
            spawnBox();
            Debug.Log("aha");
        }
        if (Input.GetKeyDown("b"))
	    {
            inviroFix("left");
	    }
        if (Input.GetKeyUp("b"))
        {
            inviroFix("lReturn");
        }
        if (Input.GetKeyDown("n"))
        {
            inviroFix("right");
        }
        if (Input.GetKeyUp("n"))
        {
            inviroFix("rReturn");
        }
        if (Input.GetKeyDown("w"))
        {
            miniGames("gravity");
        }
        if (Input.GetKeyUp("w"))
        {
            miniGames("gReturn");
        }
        if (Input.GetKeyDown("x"))
        {
            miniGames("lights");
        }
        if (Input.GetKeyUp("x"))
        {
            miniGames("lReturn");
        }
        if (Input.GetKey("up"))
        {
            buttonControl("up");
        }
        if (Input.GetKey("down"))
        {
            buttonControl("down");
        }
        if (Input.GetKeyDown("right"))
        {
            cameraControl("packagerV");
        }
        if (Input.GetKeyDown("left"))
        {
            cameraControl("shrinkerV");
        }
        if (Input.GetKeyDown("enter"))
        {
            cameraControl("portalV");
        }
        if (Input.GetKeyUp("enter"))
        {
            cameraControl("return0");
        }
        if (Input.GetKeyUp("left"))
        {
            cameraControl("return1");
        }
        if (Input.GetKeyUp("right"))
        {
            cameraControl("return2");
        }
        if (Input.GetKeyDown("space"))
        {
            buttonControl("act1");
        }

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
        #region open gate
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

        #region next gate
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

        #region prev gate
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

        #region button b
        if (oneThreeButton == true)
        {
            //Debug.Log("oneThree : pressed and held");
        }
        if (oneThreeDown == true)
        {
            //Debug.Log(" oneThree : pressed once");
            inviroFix("left");
        }
        if (oneThreeUp == true)
        {
            //Debug.Log("oneThree : released");
            inviroFix("lReturn");
        }
        #endregion

        #region button a
        if (oneFourButton == true)
        {
            //Debug.Log("oneFour : pressed and held");
        }
        if (oneFourDown == true)
        {
            //Debug.Log(" oneFour : pressed once");
            inviroFix("right");
        }
        if (oneFourUp == true)
        {
            //Debug.Log("oneFour : released");
            inviroFix("rReturn");
        }
        #endregion

        #region obj spawn
        if (oneFiveButton == true)
        {
            //Debug.Log("oneFive : pressed and held");
        }
        if (oneFiveDown == true)
        {
            //Debug.Log(" oneFive : pressed once");
            //spawn obj
        }
        if (oneFiveUp == true)
        {
            //Debug.Log("oneFive : released");
        }
        #endregion

        #region select grav
        if (oneSixButton == true)
        {
            //Debug.Log("oneSix : pressed and held");
        }
        if (oneSixDown == true)
        {
            //Debug.Log(" onesix : pressed once");
            miniGames("gravity");
        }
        if (oneSixUp == true)
        {
            //Debug.Log("oneSix : released");
            miniGames("gReturn");
        }
        #endregion

        #region select light
        if (oneSevenButton == true)
        {
            //Debug.Log("oneSeven : pressed and held");
        }
        if (oneSevenDown == true)
        {
            //Debug.Log(" oneSeven : pressed once");
            miniGames("lights");
        }
        if (oneSevenUp == true)
        {
            //Debug.Log("oneSeven : released");
            miniGames("lReturn");
        }
        #endregion

        #region spawn enmpty box
        if (oneEightButton == true)
        {
            //Debug.Log("oneEight : pressed and held");
        }
        if (oneEightDown == true)
        {
            //Debug.Log(" oneEight : pressed once");
            spawnBox();
            SundManager.PlaySound("Button");
        }
        if (oneEightUp == true)
        {
            //Debug.Log("oneEight : released");
        }
        #endregion

        //ouput constructor
        #region down
        if (twoZeroButton == true)
        {
            //Debug.Log("twoZero : pressed and held");
            buttonControl("down");
        }
        if (twoZeroDown == true)
        {
            //Debug.Log("twoZero : pressed once");
        }
        if (twoZeroUp == true)
        {
            //Debug.Log("twoZero : released");
            //SundManager.ToggleLoop("MachineLoop");
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
            buttonControl("up");
        }
        if (twoFourDown == true)
        {
            //Debug.Log(" twoFour : pressed once");
        }
        if (twoFourUp == true)
        {
            //Debug.Log("oneFour : released");
            //SundManager.ToggleLoop("MachineLoop");
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

        #region Camera packager view
        if (twoSixButton == true)
        {
            //Debug.Log("twoSix : pressed and held");
        }
        if (twoSixDown == true)
        {
            //Debug.Log(" twosix : pressed once");
            Debug.Log("Toggle camera next");
            cameraControl("packagerV");
        }
        if (twoSixUp == true)
        {
            //Debug.Log("twoSix : released");
            cameraControl("return2");
        }
        #endregion

        #region shrinker view 
        if (twoSevenButton == true)
        {
            //Debug.Log("twoSeven : pressed and held");
        }
        if (twoSevenDown == true)
        {
            //Debug.Log(" twoSeven : pressed once");
            //Debug.Log("Toggle camera back");
            cameraControl("shrinkerV");
        }
        if (twoSevenUp == true)
        {
            //Debug.Log("twoSeven : released");
            cameraControl("return1");
        }
        #endregion

        #region portal view
        if (twoEightButton == true)
        {
            //Debug.Log("twoEight : pressed and held");
        }
        if (twoEightDown == true)
        {
            //Debug.Log(" twoEight : pressed once");
            cameraControl("portalV");
        }
        if (twoEightUp == true)
        {
            //Debug.Log("twoEight : released");
            cameraControl("return0");
        }
        #endregion

        #endregion
        #endregion
    }

    private void cameraControl(string input) 
    {
        byte newCam = currCam;
        if (cameraInUse == false)
        {
            switch (input)
            {
                case "portalV":
                    SundManager.PlaySound("Button");
                    newCam = 0;
                    break;
                case "shrinkerV":
                    SundManager.PlaySound("Button");
                    newCam = 1;
                    break;
                case "packagerV":
                    SundManager.PlaySound("Button");
                    newCam = 2;
                    break;
                default:
                    break;
            }
            cameraInUse = true;
            
        }
        else
        {
            switch (currCam)
            {
                case 0:
                    if (input == "return0")
                    {
                        newCam = 3;
                        cameraInUse = false;
                    }
                    break;
                case 1:
                    if (input == "return1")
                    {
                        newCam = 3;
                        cameraInUse = false;                        
                    }
                    break;
                case 2:
                    if (input == "return2")
                    {
                        newCam = 3;
                        cameraInUse = false;                        
                    }
                    break;
                default:
                    break;
            }
        }
        GetComponent<CameraHelper>().OnChangeCamera(newCam);

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
                messageSender(input, ref shrinker);
                break;
            case 2 :
                // send to ..
                messageSender(input, ref packer);
                break;
            case 3 :
                //send to ...
                break;
            case 4 :
                //spawnBox(input);
                break;
            default:
                break;
        }
    }
    private void messageSender(string mssg,ref GameObject rec)
    {
        rec.SendMessage("buttonPress", mssg);
    }
    private void spawnBox() 
    {
            Instantiate(box, boxPos, Quaternion.Euler(boxRot));       
    }
    IEnumerator enviro()
    {
        do
        {
            if (gravity < 1)
            {
                gravity = gravity + gravDegradeSpeed;
                Physics.gravity = new Vector3(0, gravity, 0);
                Bar1.GetComponent<RectTransform>().sizeDelta = new Vector2(25, (1+gravity)* 250/2);

            }
            if (lightQuali > 0)
            {
                lightQuali = lightQuali - lightDegradeSpeed;
                Bar2.GetComponent<RectTransform>().sizeDelta = new Vector2(25, lightQuali * 250);

            }
            yield return 0; 
           
        } while (inviro);
    }
    private void miniGames(string input) 
    {
        if (resourceSelected == false)
        {
            SundManager.PlaySound("Button");
            if (input == "gravity")
            {
                gravSelected = true;
                resourceSelected = true; 
            }
            else if(input == "lights")
            {
                lightSelected = true;
                resourceSelected = true;
            }
        }
        else if (input == "gReturn")
        {
            gravSelected = false;
            resourceSelected = false;
        }
        else if (input == "lReturn")
        {
            lightSelected = false;
            resourceSelected = false;
        }
    }
    private void gravControl(string input) 
    {
        if (gravSelected == true)
        {
            if (input == "left" || input == "right")
            {
                Debug.Log("ah");
                if (gravity > -1)
                {
                    gravity = gravity - 0.25F;
                    Physics.gravity = new Vector3(0, gravity, 0);
                }

            }
        }

    }
    private void inviroFix(string input)
    {
        if (lightSelected == true)
        {
            
            if (input == "left" || input == "right")
            {
                SundManager.PlaySound("Button");
                if (lightQuali <= 1)
                {
                    lightQuali += lightUp;
                    if (lightQuali > 0)
                    {
                        light3.enabled = true;
                        allLight.enabled = true;
                        if (lightQuali > 0.45)
                        {
                            light2.enabled = true;
                            if (lightQuali > 0.75)
                            {
                                light1.enabled = true;
                            }
                        }
                    }
                }
            }
        }
        if (gravSelected == true)
        {
            if (input == "left" || input == "right")
            {
                SundManager.PlaySound("Button");
                Debug.Log("ah");
                if (gravity > -1)
                {
                    gravity = gravity - 0.25F;
                    Physics.gravity = new Vector3(0, gravity, 0);
                }

            }
        }

    }
}


