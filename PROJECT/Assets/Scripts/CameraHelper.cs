using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraHelper : MonoBehaviour {

    // Use this for initialization
    public GameObject Title;
    public GameObject Desc;
	void Start () {
		
	}
	public void OnChangeCamera(int cameraId)
    {
        switch (cameraId)
        {
            case 0:
                Title.GetComponent<Text>().text = "Overview";
                Desc.GetComponent<Text>().text = @"Spawn package contents using
the lower left button of the Machine Controls

Change the view using 
the buttons directly below the joystick";
                break;
            case 1:
                Title.GetComponent<Text>().text = "Someting";
                Desc.GetComponent<Text>().text = @"Spawn package contents using
the lower left button of the Machine Controls

Change the view using 
the buttons directly below the joystick";
                break;
            case 2:
                Title.GetComponent<Text>().text = "rekoqw";
                Desc.GetComponent<Text>().text = @"Spawn package contents using
the lower left button of the Machine Controls

Change the view using 
the buttons directly below the joystick";
                break;
            case 3:
                Title.GetComponent<Text>().text = "sadasd";
                Desc.GetComponent<Text>().text = @"Spawn package contents using
the lower left button of the Machine Controls

Change the view using 
the buttons directly below the joystick";
                break;
            default:
                //Console.WriteLine("Default case");
                break;
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
