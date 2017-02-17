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
    public void UpdateText(string text)
    {
        //if (gameOver)
        //    Desc.GetComponent<Text>().text = "Game Over";

        //else
            Desc.GetComponent<Text>().text = text;

    }
    public void OnChangeCamera(int cameraId)
    {
        switch (cameraId)
        {
            case 0:
                Title.GetComponent<Text>().text = "Overview";
                
                break;
            case 1:
                Title.GetComponent<Text>().text = "Scaling Machine";
               
                break;
            case 2:
                Title.GetComponent<Text>().text = "Packaging Machine";
               
                break;
            case 3:
                Title.GetComponent<Text>().text = "Overview 2";
                
                break;
            case 4:
                Title.GetComponent<Text>().text = "Box refill station";
                
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
