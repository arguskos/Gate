using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveir : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody)
            other.transform.position += new Vector3(-1, 0, 0)*Time.deltaTime;
    }
}
