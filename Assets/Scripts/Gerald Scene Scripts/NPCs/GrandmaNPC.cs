using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrandmaNPC : NPC
{//the name of the npc
    string testName = "Test NPC";

    //the game objects that will change when event is triggered
    public GameObject obstacle1;


    //initializers for NPC dialogue windows
    TalkBox dialo1 = new TalkBox("Hey, What's Up?", null, false);
    ChoiceBox dialo2 = new ChoiceBox("Pick Choice 3 to clear the obstacles.", new ChoiceBox.Choice("Choice 1", null, false),
        new ChoiceBox.Choice("Choice 2", null, false),
        new ChoiceBox.Choice("Choice 3", null, true));
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
