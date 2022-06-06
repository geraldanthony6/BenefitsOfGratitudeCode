using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//a file for an moving NPC used for testing purposes
// Authors: Charlie Christakos
public class TestMovingNPC : NPC
{
    //the name of the npc
    string testName = "Test Moving NPC";

    //initializers for NPC dialogue windows
    TalkBox dialo1 = new TalkBox("I am a moving NPC", null, false);
    DialoBox dialoEnd = new DialoBox();

    // Start is called before the first frame update
    void Start()
    {
        //set name
        npcName.GetComponent<Text>().text = testName;
        //link dialogue windows
        dialo1.next = dialoEnd;
        //Ready the root Dialo Box of dialogue tree
        dialogue = dialo1;
    }
}
