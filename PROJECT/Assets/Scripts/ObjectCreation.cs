using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreation : MonoBehaviour {
    public GameObject[] ToCreate;
    private float _timer;
    public float MaxTime=3; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        _timer += Time.deltaTime;
        if (_timer>MaxTime)
        {
            _timer = 0;
            Instantiate(ToCreate[0], transform.position, Quaternion.identity);
        }
	}
}
