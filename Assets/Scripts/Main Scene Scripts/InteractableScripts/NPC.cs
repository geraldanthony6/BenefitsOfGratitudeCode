using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//A non-playable character that the player may talk to
//Author: Charlie Christakos
public class NPC : Interactable
{

    //the npc dialogue window
    public GameObject dialogueWindow;
    public GameObject dialogueText;
    public GameObject choice1;
    public GameObject choice1Text;
    public GameObject choice2;
    public GameObject choice2Text;
    public GameObject choice3;
    public GameObject choice3Text;

    //the specific npc being talked to
    public GameObject currNPC;

    //the name of the npc that displays above its head
    public GameObject npcName;

    //the player who is talking to the NPC
    public GameObject player;

    //the root dialogue box of this NPC's dialogue tree
    public DialoBox dialogue;

    //the data of the currently displayed dialogue window
    public DialoBox currDialoBox;

    // Update is called once per frame
    void Update()
    {
        //when mouse clicked during dialogue
        if (dialogueWindow.activeSelf == true && Input.GetMouseButtonDown(0))
        {
            currNPC = player.GetComponent<PlayerInteract>().currInteractable;
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            //goes to next step in dialogue tree when dialogue ui is clicked on
            switch (hit.collider.gameObject.name)
            {
                //if clicks on talk box window
                case "Dialogue Window":
                    TalkBox currTalkBox = (TalkBox)currDialoBox;
                    Debug.Log("currTalkBox.triggersEvent " + currTalkBox.triggersEvent);
                    if (currTalkBox.triggersEvent == true)
                    {
                        currNPC.GetComponent<NPC>().eventTrigger();
                    }
                    readDialoBox(currTalkBox.next);
                    break;
                //if clicks first dialogue choice
                case "Choice1":
                    ChoiceBox chose1 = (ChoiceBox)currDialoBox;
                    if (chose1.choiceOne.triggersEvent == true)
                    {
                        currNPC.GetComponent<NPC>().eventTrigger();
                    }
                    readDialoBox(chose1.choiceOne.next);
                    break;
                //if clicks second dialogue choice
                case "Choice2":
                    ChoiceBox chose2 = (ChoiceBox)currDialoBox;
                    if (chose2.choiceTwo.triggersEvent == true)
                    {
                        currNPC.GetComponent<NPC>().eventTrigger();
                    }
                    readDialoBox(chose2.choiceTwo.next);
                    break;
                //if clicks third dialogue choice
                case "Choice3":
                    ChoiceBox chose3 = (ChoiceBox)currDialoBox;
                    if (chose3.choiceThree.triggersEvent == true)
                    {
                        currNPC.GetComponent<NPC>().eventTrigger();
                    }
                    readDialoBox(chose3.choiceThree.next);
                    break;
            }
        }
    }

    //open dialogue when player interacts with NPC
    public override void OnInteract()
    {
        base.OnInteract();
        //stops movement of npc and player
        if (GetComponent<NpcMove>() != null)
        {
            GetComponent<NpcMove>().speed = 0f;
        }
        player.GetComponent<PlayerMove>().moveSpeed = 0f;
        //turns on dialogue UI
        dialogueWindow.SetActive(true);
        choice1.GetComponent<SpriteRenderer>().enabled = false;
        choice2.GetComponent<SpriteRenderer>().enabled = false;
        choice3.GetComponent<SpriteRenderer>().enabled = false;
        //displays the first bit of this NPC's dialogue
        readDialoBox(dialogue);
    }

    //converts data of DialoBox into the contents of the dialogue window
    public void readDialoBox(DialoBox box)
    {
        currDialoBox = box;
        //manages if/how dialogue should be displayed in UI
        switch (box.isChoice)
        {
            //manages dialogue UI if player selected choices are involved
            case true:

                //configure colliders
                dialogueWindow.GetComponent<BoxCollider2D>().enabled = false;
                choice1.GetComponent<BoxCollider2D>().enabled = true;
                choice2.GetComponent<BoxCollider2D>().enabled = true;
                choice3.GetComponent<BoxCollider2D>().enabled = true;

                //display data
                ChoiceBox choiceBox = (ChoiceBox)box;
                dialogueText.GetComponent<Text>().text = choiceBox.promptText;
                choice1Text.GetComponent<Text>().text = choiceBox.choiceOne.choiceText;
                choice2Text.GetComponent<Text>().text = choiceBox.choiceTwo.choiceText;
                choice3Text.GetComponent<Text>().text = choiceBox.choiceThree.choiceText;

                break;
            //manages dialogue UI if player selected choices aren't involved
            case false:

                //configure colliders
                dialogueWindow.GetComponent<BoxCollider2D>().enabled = true;
                choice1.GetComponent<BoxCollider2D>().enabled = false;
                choice2.GetComponent<BoxCollider2D>().enabled = false;
                choice3.GetComponent<BoxCollider2D>().enabled = false;

                //display data
                TalkBox talkBox = (TalkBox)box;
                dialogueText.GetComponent<Text>().text = talkBox.talkText;
                choice1Text.GetComponent<Text>().text = "";
                choice2Text.GetComponent<Text>().text = "";
                choice3Text.GetComponent<Text>().text = "";

                break;
            //ends dialogue with NPC if an "end point" (an empty DialoBox with isChoice = null) is being read
            case null:
                //configure colliders
                dialogueWindow.GetComponent<BoxCollider2D>().enabled = true;
                choice1.GetComponent<BoxCollider2D>().enabled = true;
                choice2.GetComponent<BoxCollider2D>().enabled = true;
                choice3.GetComponent<BoxCollider2D>().enabled = true;

                //end dialogue
                dialogueWindow.SetActive(false);
                npcName.SetActive(false);
                player.GetComponent<PlayerMove>().moveSpeed = 5f;
                if (GetComponent<NpcMove>() != null)
                {
                    GetComponent<NpcMove>().speed = 3f;
                }
                break;
        }
    }

    //the event that an npc will trigger at a certain point during dialogue
    public virtual void eventTrigger()
    {

    }
}
