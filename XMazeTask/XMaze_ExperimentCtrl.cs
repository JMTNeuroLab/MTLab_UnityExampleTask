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
    public XMaze_TaskInfo xMazeTaskInfo;

    // To keep track whether the targets will be displayed at the north or south end
    // of the maze. 
    public bool IsNorth { get; protected set; }

    // OnEnable and OnDisable function calls are important because they connect the
    // experiment controller with the events controller for communication across classes. 
    private new void OnEnable()
    {
        // Important, do not remove ---
        base.OnEnable();
        taskInfo = xMazeTaskInfo;
        // ----------------------------

        // First trial is always north
        IsNorth = true;
    }

    // This function allows the base-class Experiment Controller to 
    // access values defined here (e.g. the IsNorth boolean). The returned value 
    // needs to be converted into the proper format with (format) before: 
    // bool ReturnedIsNorth = (bool)returnValue("IsNorth");
    public override object ReturnValue(string name)
    {
        return GetType().GetProperty(name).GetValue(this);
    }

    private void Start()
    {
        // Base function call. Do not remove. 
        base.Initialize();
    }

    public override void FreezePlayer(bool ON)
    {
        // if ON==true then player rotation and backward movement are frozen
        playerController.FreezeRotation(ON);
        playerController.ConstrainForward(ON);
    }
}
