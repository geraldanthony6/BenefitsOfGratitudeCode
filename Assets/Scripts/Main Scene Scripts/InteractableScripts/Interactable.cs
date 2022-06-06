using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The parent class for all gameobjects that gan be interacted with by player
//Author: Charlie Christakos
public class Interactable : MonoBehaviour
{
    //The method called when player interacts with a child of this class
    public virtual void OnInteract()
    {

    }
}
