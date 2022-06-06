using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

//A script which Triggers the cutscene of the player character attending class
//Author: Charlie Christakos
public class PlayGymTimeline : EventSpace
{
    //NPC GameObjects
    public GameObject teacher2;
    public GameObject student1;
    public GameObject student2;
    public GameObject student3;
    public GameObject student4;
    public GameObject student5;

    //Level Exit Gameobject
    public GameObject levelExit;

    //the gameobject that serves as the event-space
    public GameObject space;

    //the playable director of the level exit timeline
    public PlayableDirector playableDirector;

    //triggers the cutscene at the front door
    public override void OnEnter()
    {
        base.OnEnter();
        Debug.Log("OnEnter Called");
        //enable animators
        teacher2.GetComponent<Animator>().enabled = true;
        student1.GetComponent<Animator>().enabled = true;
        student2.GetComponent<Animator>().enabled = true;
        student3.GetComponent<Animator>().enabled = true;
        student4.GetComponent<Animator>().enabled = true;
        student5.GetComponent<Animator>().enabled = true;
        //enable level exit
        levelExit.SetActive(true);
        //play timeline
        playableDirector.Play();
        space.SetActive(false);
    }
}
