using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

//A script which Triggers the cutscene of the player character attending class
//Author: Charlie Christakos
public class PlayClassTimeline : EventSpace
{
    //the gameobject that serves as the event-space
    public GameObject space;

    //the playable director of the level exit timeline
    public PlayableDirector playableDirector;

    //triggers the cutscene at the front door
    public override void OnEnter()
    {
        base.OnEnter();
        Debug.Log("OnEnter Called");
        playableDirector.Play();
        space.SetActive(false);
    }
}
