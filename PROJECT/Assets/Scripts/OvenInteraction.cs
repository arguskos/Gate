using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvenInteraction : MonoBehaviour
{
    List<Collider> TriggerList = new List<Collider>();
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("Fade");
    }

    IEnumerator Fade()
    {
        
        for (float f = 1f; f >= 0; f -= 0.1f)
        {

            foreach (var col in TriggerList)
            {
                if (col.tag == "Package")
                {

                    col.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                    yield return null;
                }
                yield return null;
            }

        }
    }

    void OnTriggerEnter(Collider other)
    {
        other.transform.position = new Vector3(0, 0, 0);

        //if the object is not already in the list
        if (!TriggerList.Contains(other))
        {
            Debug.Log(other.tag);
            //add the object to the list
            TriggerList.Add(other);

        }
    }

    //called when something exits the trigger
    void OnTriggerExit(Collider other)
    {
        //if the object is in the list
        if (TriggerList.Contains(other))
        {
            //remove it from the list
            TriggerList.Remove(other);
        }
    }
}
