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
        Random.seed = 42;
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
    public void Spawn(int id)
    {
        var created=Instantiate(box, transform.position, Quaternion.identity);
        created.GetComponent<Renderer>().material.color = Colors[id-1];
        created.GetComponent<ObjectsPortalID>().PortalId = id;
        created.GetComponent<ViveGrip_Grabbable>().enabled = true;
        float random = Random.Range(0.5f, 5f);
        created.GetComponent<Transform>().localScale = new Vector3(0.136f * random, 0.136f * random, 0.136f * random);
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Object")
            Spawn( other.GetComponent<ObjectsPortalID>().PortalId);
        if (other.tag == "Machinable")
            Spawn( other.GetComponent<ObjectsPortalID>().PortalId);
            
    }

}
