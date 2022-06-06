using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//a file for an NPC used for a tutorial video
// Authors: Charlie Christakos
public class TutorialNPC : NPC
{

    //the name of the npc
    string tutorialNPCName = "Tutorial NPC";

    //the square that will change color
    public GameObject square;

    /*initializers for NPC dialogue windows
    TalkBox dialo1 = new TalkBox("I have a question for you:", null, false);
    ChoiceBox dialo2 = new ChoiceBox("What color is the sky?", new ChoiceBox.Choice("Red", null, false),
        new ChoiceBox.Choice("Green", null, false),
        new ChoiceBox.Choice("Blue", null, true));
    DialoBox dialoEnd = new DialoBox();
    */

    ChoiceBox dialo1 = new ChoiceBox("What is 2 + 2?:", new ChoiceBox.Choice("3", null, false),
        new ChoiceBox.Choice("5", null, false),
        new ChoiceBox.Choice("4", null, true));
    TalkBox dialo2 = new TalkBox("Nice try, try again!", null, false);
    TalkBox dialo3 = new TalkBox("That is correct!", null, false);
    DialoBox dialoEnd = new DialoBox();


    // Start is called before the first frame update
    void Start()
    {
        //set name
        npcName.GetComponent<Text>().text = tutorialNPCName;
        /*link dialogue windows
        dialo1.next = dialo2;
        dialo2.choiceOne.next = dialoEnd;
        dialo2.choiceTwo.next = dialoEnd;
        dialo2.choiceThree.next = dialoEnd;
        dialogue = dialo1;
        */
        dialo1.choiceOne.next = dialo2;
        dialo1.choiceTwo.next = dialo2;
        dialo1.choiceThree.next = dialo3;
        dialo2.next = dialo1;
        dialo3.next = dialoEnd;
        //Ready the root Dialo Box of dialogue tree
        dialogue = dialo1;
    }

    //the event that this NPC will trigger at some point during dialogue
    public override void eventTrigger()
    {
        base.eventTrigger();
        //change color of square
        square.GetComponent<SpriteRenderer>().color = new Color(0, 1, 0, 1);
    }
}
