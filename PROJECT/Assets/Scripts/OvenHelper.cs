using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvenHelper : ViveGrip_Grabbable
{
    private bool _isMovable = true;
    private bool _startGrab = false;
    void ViveGripGrabStart(ViveGrip_GripPoint gripPoint)
    {
        _isMovable = false;
    }
    void ViveGripGrabStop(ViveGrip_GripPoint gripPoint)
    {
        _isMovable = true;
    }
    private void Update()
    {
        //Debug.Log(transform.eulerAngles.y);
        if (!_isMovable)
        {
            if(transform.eulerAngles.y<359&& transform.eulerAngles.y >350)
            {
               // transform.eulerAngles = Vector3.zero;
            }
        }
    }
}
