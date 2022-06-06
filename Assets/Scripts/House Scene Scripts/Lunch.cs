using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//The lunch needed to finish the house level, changes tutorial text when picked up
//Author: Charlie Christakos
public class Lunch : Key
{
    //the tutorial prompt text
    public Text tutorialText;

    //add the change to the tutorial prompt in OnEnter
    public override void OnEnter()
    {
        base.OnEnter();
        tutorialText.text = "Press E to interact with people or objects.";
        //put item in inventory
        GameObject currEventSpace = player.GetComponent<PlayerInteract>().currEventSpace;
        Item currItem = currEventSpace.GetComponent<Item>();
        inventory.GetComponent<Inventory>().pickUpItem(currItem);
        //remove the item sprite from game world
        currEventSpace.SetActive(false);
        Debug.Log("this item has been stored to space " + inventory.GetComponent<Inventory>().numItems + " of your inventory");
        
    }
}
