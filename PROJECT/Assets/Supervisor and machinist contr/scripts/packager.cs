using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class packager : MonoBehaviour {

    private bool objectInPacker = false;
    private Collider toPackObj;
    private Collider toPackObj1;

    public GameObject  thisMachine;
    public GameObject packedPackage;
    public float machineSpeed = 0.005F;
    public float maxHeight = 1.605F;
    public float minHeight = 0.982F;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "OpenPackage" )
        {
            toPackObj = other;
            objectInPacker = true;
        }
        if (other.tag == "Object")
        {
            toPackObj1 = other;
            objectInPacker = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "OpenPackage" )
        {
            objectInPacker = false;
        }
    }
    void buttonPress(string input)
    {
        //minwaard 0.982
        //maxwaarde 1.605
        if (input == "up" && transform.position.y <= maxHeight)
        {
            Debug.Log("upwego");
            transform.Translate(Vector3.forward * machineSpeed);
        }
        if (input == "down" && transform.position.y >= minHeight)
        {
            Debug.Log("upwego");
            transform.Translate(Vector3.back * machineSpeed);
        }
        if (objectInPacker )
        {
            Debug.Log("woop i git it");

            if (input == "act1")
            {
                //pack package
                packPac();

            }
            else if (input == "act2")
            {
                //miss verpakking vernielen ? 
            }
        }

    }
    void packPac() 
    {
        Debug.Log(toPackObj1.GetComponent<ViveGrip_Grabbable>().enabled);
        if (!toPackObj1.GetComponent<ViveGrip_Grabbable>().enabled)
        {
            Vector3 pos = toPackObj.transform.position;
            Quaternion rot = Quaternion.identity;
     
      

            var obj = Instantiate(packedPackage, pos, rot);
            obj.GetComponent<ObjectsPortalID>().PortalId = toPackObj1.GetComponent<ObjectsPortalID>().PortalId;
            obj.GetComponent<ObjectsPortalID>().Object = toPackObj1.gameObject;

            Destroy(toPackObj.gameObject);
            Destroy(toPackObj1.gameObject);
        }
    }
}
