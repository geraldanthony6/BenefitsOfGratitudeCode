using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//controls the interactions between player and other game objects
//Author: Charlie Christakos
public class PlayerInteract : MonoBehaviour
{

    //the currently object in which the player is ready to interact with
    public GameObject currInteractable = null;

    //the current event-space that the player has entered
    public GameObject currEventSpace = null;

    // Update is called once per frame
    void Update()
    {
        //interacts with currInteractable when e key is pressed
        if (Input.GetButtonDown("Interact") && currInteractable)
        {
            currInteractable.GetComponent<Interactable>().OnInteract();
        }
    }

    //records current important objects in range of player
    void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            //records the current interactable that's ready to be interacted with
            case "Interactable":
                Debug.Log(other.name);
                currInteractable = other.gameObject;
                break;
            //records the current event-space that's ready to trigger
            case "EventSpace":
                Debug.Log(other.name);
                currEventSpace = other.gameObject;
                currEventSpace.GetComponent<EventSpace>().OnEnter();
                break;
        }
    }

    //records current interactable object in range of player
    void OnTriggerExit2D(Collider2D other)
    {
        switch (other.tag)
        {
            //sets current interactable to null when no interactables are in range
            case "Interactable":
                if (other.gameObject == currInteractable)
                {
                    currInteractable = null;
                }
                break;
            //sets current event-space to null when no event-space are in range
            case "EventSpace":
                if (other.gameObject == currEventSpace)
                {
                    currEventSpace.GetComponent<EventSpace>().OnExit();
                    currEventSpace = null;
                }
                break;
        }
    }
}
