using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//The player character's teacher before gym class (NPC)
//Author: Charlie Christakos
public class TeacherPhase2 : NPC
{
    //the name of the npc
    string testName = "Teacher";

    //the game objects that will change when event is triggered
    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    public GameObject obstacle4;
    public GameObject obstacle5;
    public GameObject obstacle6;
    public Transform obstacle1Next;
    public Transform obstacle2Next;
    public Transform obstacle3Next;
    public Transform obstacle4Next;
    public Transform obstacle5Next;
    public Transform obstacle6Next;

    //initializers for NPC dialogue windows
    TalkBox dialo1 = new TalkBox("How are you feeling?", null, false);
    ChoiceBox dialo2 = new ChoiceBox("How do you feel?", new ChoiceBox.Choice("I'm mad!", null, false),
        new ChoiceBox.Choice("I'm angry!", null, false),
        new ChoiceBox.Choice("I'm having fun!", null, true));
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
        //changes next position for obstacles
        obstacle1.GetComponent<Obstacle>().nextPosition = obstacle1Next;
        obstacle2.GetComponent<Obstacle>().nextPosition = obstacle2Next;
        obstacle3.GetComponent<Obstacle>().nextPosition = obstacle3Next;
        obstacle4.GetComponent<Obstacle>().nextPosition = obstacle4Next;
        obstacle5.GetComponent<Obstacle>().nextPosition = obstacle5Next;
        obstacle6.GetComponent<Obstacle>().nextPosition = obstacle6Next;
        //clears obstacles, opening passage through the back door of the testing house
        obstacle1.GetComponent<Obstacle>().clearObstacle();
        obstacle2.GetComponent<Obstacle>().clearObstacle();
        obstacle3.GetComponent<Obstacle>().clearObstacle();
        obstacle4.GetComponent<Obstacle>().clearObstacle();
        obstacle5.GetComponent<Obstacle>().clearObstacle();
        obstacle6.GetComponent<Obstacle>().clearObstacle();
    }
}