using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//A class for Items that can be stored in an inventory when picked up
//Authors: Gerald Anthony, jr.
//         Charlie Christakos
public class Item : EventSpace
{
    //the player who's picking up the item
    public GameObject player;
    //reference for player inventory
    public GameObject inventory;
    //The image of the item that shows up in the inventory UI
    public Sprite itemImage;


    //pickup item when player enters item's collider
    public override void OnEnter()
    {
        base.OnEnter();
        //put item in inventory
        GameObject currEventSpace = player.GetComponent<PlayerInteract>().currEventSpace;
        Item currItem = currEventSpace.GetComponent<Item>();
        inventory.GetComponent<Inventory>().pickUpItem(currItem);
        //remove the item sprite from game world
        currEventSpace.SetActive(false);
        Debug.Log("this item has been stored to space " + inventory.GetComponent<Inventory>().numItems + " of your inventory");
    }
}
