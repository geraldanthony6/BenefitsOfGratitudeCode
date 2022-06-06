using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Interactable
{

    public override void OnInteract()
    {
        EventTrigger();
    }

    public virtual void EventTrigger()
    {

    }
}
