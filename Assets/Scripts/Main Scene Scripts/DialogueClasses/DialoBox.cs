using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The data structure of a box of NPC dialougue
//Authors: Charlie Christakos
public class DialoBox : MonoBehaviour {

    public bool? isChoice;
	
    //creates an empty dialogue box, used to end NPC dialogue
    public DialoBox()
    {
        isChoice = null;
    }
}
