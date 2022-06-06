using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//A dialogue box which only consists of text
//Authors: Charlie Christakos
public class TalkBox : DialoBox {

    //The text that the box will show
    public string talkText;
    //The Dialogue box, if any, that will follow once the player inputs to continue
    public DialoBox next;
    //Denotes whether the input to continue will trigger an event
    public bool triggersEvent;

    //primary constructor
    public TalkBox(string inText, DialoBox inNext, bool inTriggers) {
        isChoice = false;
        talkText = inText;
        next = inNext;
        triggersEvent = inTriggers;
    }
}
