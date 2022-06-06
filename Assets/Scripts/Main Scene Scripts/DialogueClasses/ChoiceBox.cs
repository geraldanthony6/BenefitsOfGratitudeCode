using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//A dialogue Box that gives the player a choice between a few options
//Authors: Charlie Christakos
public class ChoiceBox : DialoBox {

    //The text which the player's choice will  respond to
    public string promptText;
    //The 1 to 3 choices the player can make (null means choice gameObject is dissabled)
    public Choice choiceOne;
    public Choice choiceTwo;
    public Choice choiceThree;

    //nested class corresponding to each individual choice
    public class Choice {

        //The text of which the choice consists of
        public string choiceText;
        //The next dialogue box, if any, the choice will lead to
        public DialoBox next;
        //Determines whether choice will lead to an event being triggered
        public bool triggersEvent;

        //primary constructor
        public Choice(string inText, DialoBox inNext, bool inTriggers) {
            choiceText = inText;
            next = inNext;
            triggersEvent = inTriggers;
        }
    }

    //primary constructor
    public ChoiceBox(string inText, Choice inChoice1, Choice inChoice2, Choice inChoice3)
    {
        isChoice = true;
        promptText = inText;
        choiceOne = inChoice1;
        choiceTwo = inChoice2;
        choiceThree = inChoice3;
    }
}
