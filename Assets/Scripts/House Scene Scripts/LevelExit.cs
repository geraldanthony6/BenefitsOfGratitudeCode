using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

//A script which Triggers the level exit cutscene when the player leaves the house level
//Author: Charlie Christakos
public class LevelExit : EventSpace
{
    //the UI canvas
    public GameObject canvas;

    //the playable director of the level exit timeline
    public PlayableDirector playableDirector;

    //triggers the cutscene at the front door
    public override void OnEnter()
    {
        canvas.SetActive(false);
        playableDirector.Play();
    }
}
