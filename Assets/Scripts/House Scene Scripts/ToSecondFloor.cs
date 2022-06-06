using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//A script which transitions the player from first floor to second floor of the house level
//Author: Charlie Christakos
public class ToSecondFloor : EventSpace
{
    //the position of the player
    public Transform playerTransform;

    //the house's first floor
    public GameObject firstFloor;

    //the house's second floor
    public GameObject secondFloor;

    //called when space is entered
    public override void OnEnter()
    {

    }

    // switch floors if player exits space upwards
    public override void OnExit()
    {
        if(playerTransform.position.y > -0.26)
        {
            firstFloor.SetActive(false);
            secondFloor.SetActive(true);
        }
    }
}
