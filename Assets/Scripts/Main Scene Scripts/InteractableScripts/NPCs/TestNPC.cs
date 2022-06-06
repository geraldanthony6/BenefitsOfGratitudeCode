using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//an individual NPC used for testing
//Author: Charlie Christakos
public class TestNPC : NPC
{
    //the name of the npc
    string testName = "Test NPC";

    //the game objects that will change when event is triggered
    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;

    //initializers for NPC dialogue windows
    ChoiceBox dialo1 = new ChoiceBox("This is a choice box", new ChoiceBox.Choice("this is the first choice", null, false),
        new ChoiceBox.Choice("this is the second choice", null, false),
        new ChoiceBox.Choice("this is the third choice", null, true));
    ChoiceBox dialo2 = new ChoiceBox("This is another choice box", new ChoiceBox.Choice("this is the first choice", null, false),
        new ChoiceBox.Choice("this is the second choice", null, false),
        new ChoiceBox.Choice("this is the third choice", null, false));
    TalkBox dialo3 = new TalkBox("This is a talk box", null, false);
    DialoBox dialoEnd = new DialoBox();


    // Start is called before the first frame update
    void Start()
    {
        //set name
        npcName.GetComponent<Text>().text = testName;
        //link dialogue windows
        dialo1.choiceOne.next = dialo2;
        dialo1.choiceTwo.next = dialo3;
        dialo1.choiceThree.next = dialoEnd;
        dialo2.choiceOne.next = dialoEnd;
        dialo2.choiceTwo.next = dialoEnd;
        dialo2.choiceThree.next = dialoEnd;
        dialo3.next = dialoEnd;
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
