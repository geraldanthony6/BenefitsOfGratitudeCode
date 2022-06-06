using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Author: Gerald Anthony, Jr.
public class WoodCutter : MonoBehaviour
{
    //Player Variable
    [SerializeField] private GameObject player;

    //Gameobject variable for obstacles
    [SerializeField] private GameObject[] debris;
    //Float for distance between cutters and player
    [SerializeField] private float distanceFromCutters;
    //Float for distance between debris and player
    [SerializeField] private float distanceFromDebris;

    //Bool for cutter pick up.
    private bool cuttersPickedUp = false;


    // Update is called once per frame
    void Update()
    {
        //Calculate distance between debris and player
        distanceFromDebris = Vector2.Distance(debris[0].transform.position, player.transform.position);
        //Calculate distance between player and wood cutters
        distanceFromCutters = Vector2.Distance(transform.position, player.transform.position);

        //Checks distance between player and woodcutters
        if(distanceFromCutters < 0.9f)
        {
            //Allows player to pick up wood cutters after "E" is pressed
            if(Input.GetKeyDown(KeyCode.E) && cuttersPickedUp == false)
            {
                cuttersPickedUp = true;
                
                Debug.Log("Picked Up");
            }
        }

        //Check distance between player and debris
        if(distanceFromDebris < 1.5f)
        {
            //Allows player to "cut down" debris if wood cutters are "picked up"
            if(Input.GetKeyDown(KeyCode.E) && cuttersPickedUp == true)
            {
                Destroy(debris[0]);
                Destroy(debris[1]);
            }
        }
    }
}
