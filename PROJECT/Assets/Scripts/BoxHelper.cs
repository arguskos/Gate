using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

[RequireComponent(typeof(Rigidbody))]
[DisallowMultipleComponent]
public class BoxHelper : ViveGrip_Grabbable
{
    void ViveGripGrabStart(ViveGrip_GripPoint gripPoint)
    {
        foreach (Transform child in transform)
            child.transform.GetComponent<ViveGrip_Grabbable>().enabled = true;
    }
    void ViveGripGrabStop(ViveGrip_GripPoint gripPoint)
    {
        foreach (Transform child in transform)
            child.transform.GetComponent<ViveGrip_Grabbable>().enabled = false;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Object")
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
