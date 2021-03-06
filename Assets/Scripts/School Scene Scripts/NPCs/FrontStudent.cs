using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//The student waiting at the school's front door (NPC)
//Author: Charlie Christakos
public class FrontStudent : NPC
{
    //the name of the npc
    string testName = "Student 0";

    //the game objects that will change when event is triggered
    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;

    //initializers for NPC dialogue windows
    TalkBox dialo1 = new TalkBox("Hey, how's it going?", null, false);
    ChoiceBox dialo2 = new ChoiceBox("How do you feel?", new ChoiceBox.Choice("Terrible.", null, false),
        new ChoiceBox.Choice("Great! Thanks!", null, true),
        new ChoiceBox.Choice("What?", null, false));
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
