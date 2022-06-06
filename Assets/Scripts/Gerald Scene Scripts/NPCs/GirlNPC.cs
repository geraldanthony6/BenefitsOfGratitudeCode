using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GirlNPC : NPC
{//the name of the npc
    string testName = "Girl";

    //the game objects that will change when event is triggered
    public GameObject obstacle1;


    //initializers for NPC dialogue windows
    TalkBox dialo1 = new TalkBox("Should I be nice to my old bully?", null, false);
    ChoiceBox dialo2 = new ChoiceBox("How do you respond?", new ChoiceBox.Choice("Yes, kindness is key!", null, true),
        new ChoiceBox.Choice("No.", null, false),
        new ChoiceBox.Choice("Hit them!", null, false));
    DialoBox dialoEnd = new DialoBox();

    // Start is called before the first frame update
    void Start()
    {
        //set name
        npcName.GetComponent<Text>().text = testName;
        //link dialogue windows
        dialo1.next = dialo2;
        dialo2.choiceOne.next = dialoEnd;
        dialo2.choiceTwo.next = dialoEnd;
        dialo2.choiceThree.next = dialoEnd;
        //Ready the root Dialo Box of dialogue tree
        dialogue = dialo1;
    }

    //the event that this NPC will trigger at some point during dialogue
    public override void eventTrigger()
    {
        base.eventTrigger();
        //clears obstacles, opening passage through the back door of the testing house
        obstacle1.GetComponent<Obstacle>().clearObstacle();
    }
}
