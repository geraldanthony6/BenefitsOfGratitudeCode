using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//The player characters father as an NPC
//Author: Charlie Christakos
public class Dad : NPC
{
    //the name of the npc
    string testName = "Dad";

    //the game objects that will change when event is triggered
    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;

    //initializers for NPC dialogue windows
    TalkBox dialo1 = new TalkBox("I made you a ham sandwhich for lunch son!", null, false);
    ChoiceBox dialo2 = new ChoiceBox("How do you respond to your dad?", new ChoiceBox.Choice("I hate ham!", null, false),
        new ChoiceBox.Choice("Ewwww.", null, false),
        new ChoiceBox.Choice("I love ham!", null, true));
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
        obstacle2.GetComponent<Obstacle>().clearObstacle();
        obstacle3.GetComponent<Obstacle>().clearObstacle();
    }
}
