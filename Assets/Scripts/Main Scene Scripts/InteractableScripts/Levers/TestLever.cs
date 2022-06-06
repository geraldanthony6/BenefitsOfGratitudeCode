using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//A specific Lever in the level which opens a door
//Author: Gerald Anthony, Jr.
//        Charlie Christakos
public class TestLever : Lever
{
    //the object affected by the lever, a door in this case
    public GameObject door;

    //the event that this NPC will trigger at some point during dialogue
    public override void eventTrigger()
    {
        base.eventTrigger();
        door.SetActive(false);
    }
}
