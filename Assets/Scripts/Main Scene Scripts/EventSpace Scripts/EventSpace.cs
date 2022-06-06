using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//the parent class for all spaces which trigger an event when entered
//Authors: Charlie Christakos
public class EventSpace : MonoBehaviour
{
    //called when player enters space
    public virtual void OnEnter()
    {

    }

    //called when player exits space
    public virtual void OnExit()
    {

    }
}
