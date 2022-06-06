using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//A script which transitions the player from second floor to first floor of the house level
//Authors: Charlie Christakos
public class ToFirstFloor : EventSpace
{
    //the position of the player
    public Transform playerTransform;

    //the house's first floor
    public GameObject firstFloor;

    //the house's second floor
    public GameObject secondFloor;

    //the tutorial prompt text
    public Text tutorialText;

    //called when space is entered
    public override void OnEnter()
    {

    }

    // switch floors if player exits space downwards
    public override void OnExit()
    {
        if (playerTransform.position.y < 1.37)
        {
            secondFloor.SetActive(false);
            firstFloor.SetActive(true);
            tutorialText.text = "Walk over items to add them to your inventory.";
        }
    }
}
