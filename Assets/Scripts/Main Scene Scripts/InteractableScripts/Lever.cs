using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//an interactable that represents all things which instantly (and only) trigger events when the player interacts with them
//Authors: Gerald Anthony, Jr.
//         Charlie Christakos
public class Lever : Interactable
{
    //trigger event when player interacts with Lever
    public override void OnInteract()
    {
        base.OnInteract();
        eventTrigger();
    }

    //the event that this lever will trigger
    public virtual void eventTrigger()
    {

    }
}
