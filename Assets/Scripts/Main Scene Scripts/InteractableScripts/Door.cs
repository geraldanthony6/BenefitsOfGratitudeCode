using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


//A class for a door to be opened with a key.
//Author: Gerald Anthony, Jr.
public class Door : Interactable
{
    //determines if a key item is needed to open door
    public bool locked;
    //the player inventory
    public GameObject inventory;
    //Reference for key object
    public GameObject key;
    //Player refrence
    public GameObject player;
    //current door in interacting range
    public GameObject currDoor;

    //call when player interacts with door
    public override void OnInteract()
    {
        base.OnInteract();
        //if door needs key
        if(locked == true)
        {
            //open door if player has the key
            int keyIndex = Array.IndexOf(inventory.GetComponent<Inventory>().items, key.GetComponent<Item>());
            if (keyIndex != -1)
            {
                currDoor.SetActive(false);
                inventory.GetComponent<Inventory>().consumeItem(keyIndex);
            }
        }
        else
        {
            //the door isn't locked, so just open it
            currDoor.SetActive(false);
        }
    }
}
