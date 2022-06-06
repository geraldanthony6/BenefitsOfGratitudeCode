using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//highlights a ui element on mouse hover
//Author: Charlie Christakos
public class HighlightUI : MonoBehaviour
{

    //the game object the mouse is hovering over
    public GameObject highlightedUI;

    //true if mouse is hovering over
    public bool isHighlighted;

    //ui highlighted when mouse is over it
    void OnMouseEnter()
    {
        isHighlighted = true;
        highlightedUI.GetComponent<SpriteRenderer>().enabled = true;
    }

    //ui highlighted when mouse is over it
    void OnMouseExit()
    {
        isHighlighted = false;
        highlightedUI.GetComponent<SpriteRenderer>().enabled = false;
    }
}
