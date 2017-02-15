using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstarinRotation : MonoBehaviour {

    // Use this for initialization
    public int MaxConstrainX;
    public int MaxConstrainY;
    public int MaxConstrainZ;
    public int MinConstrainX;
    public int MinConstrainY;
    public int MinConstrainZ;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var currRot = transform.eulerAngles;
        if (transform.eulerAngles.y > MaxConstrainY)
        { 
            currRot.y = MaxConstrainY;
            transform.eulerAngles = currRot;
        }
        if (transform.eulerAngles.y < MinConstrainY )
        {
            currRot.y = MinConstrainY;

            transform.eulerAngles = currRot;

        }
        if (transform.eulerAngles.z > MaxConstrainZ)
        {
            currRot.z = MaxConstrainZ;

            transform.eulerAngles = currRot;
        }
        if (transform.eulerAngles.z < MinConstrainZ)
        {
            currRot.z = MinConstrainZ;

            transform.eulerAngles = currRot;

        }
    }
}
