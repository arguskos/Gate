using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackageHelper : MonoBehaviour {

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider other)
    {
        if (other.tag=="Object")
        {
            other.GetComponent<ViveGrip_Grabbable>().enabled = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Object")
        {
            other.GetComponent<ViveGrip_Grabbable>().enabled = true;
        }
    }
}
