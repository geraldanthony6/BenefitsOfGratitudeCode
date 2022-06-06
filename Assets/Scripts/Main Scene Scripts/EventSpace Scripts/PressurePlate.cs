using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : EventSpace
{

    public override void OnEnter()
    {
        EventTrigger();
    }

    public override void OnExit()
    {

    }

    public virtual void EventTrigger()
    {

    }
}
