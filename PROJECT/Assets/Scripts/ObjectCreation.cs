using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreation : MonoBehaviour {
    // public GameObject[] ToCreate;
    // private float _timer;
    //public float MaxTime=3; 
    // Use this for initialization
    public GameObject box;
    public Color[] Colors;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //_timer += Time.deltaTime;
        //if (_timer>MaxTime)
        //{
        //    _timer = 0;
        //    Instantiate(ToCreate[0], transform.position, Quaternion.identity);
        //}
	}
    public void Spawn(GameObject obj,int id)
    {
        var created=Instantiate(obj, transform.position, Quaternion.identity);
        created.GetComponent<Renderer>().material.color = Colors[id-1];
        created.GetComponent<ObjectsPortalID>().PortalId = id;
        created.GetComponent<ViveGrip_Grabbable>().enabled = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Object")
            Spawn(other.gameObject, other.GetComponent<ObjectsPortalID>().PortalId);
        if (other.tag == "Machinable")
            Spawn(box, other.GetComponent<ObjectsPortalID>().PortalId);
            
    }

}
