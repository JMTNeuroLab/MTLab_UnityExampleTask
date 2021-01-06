using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystick_TaskInfo : TaskInfo
{
    private void OnValidate()
    {
        // Call the validate function of base-class TaskInfo.
        // Note that we do not use base.OnValidate() as this function
        // is not "virtual" so we are not "overridding" it. 
        BaseValidate();
    }
}
