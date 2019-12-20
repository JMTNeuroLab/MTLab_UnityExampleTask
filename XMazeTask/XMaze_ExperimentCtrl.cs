using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XMaze_ExperimentCtrl : ExperimentController
{
    // The taskInfo base class is defined as "dynamic" in the experiment
    // controller class, this means that the class is implemented at runtime
    // we therefore need to define it now. 
    // We use a specific sub-class of task info and set it as "taskInfo" so
    // all the base scripts will still work. 
    public XMaze_TaskInfo xTaskInfo;

    // OnEnable and OnDisable function calls are important because they connect the
    // experiment controller with the events controller for communication across classes. 
    private new void OnEnable()
    {
        // Important, do not remove ---
        base.OnEnable();
        taskInfo = xTaskInfo;
        // ----------------------------
    }

    private void Start()
    {
        // Base function call. Do not remove. 
        base.Initialize();
    }

}
