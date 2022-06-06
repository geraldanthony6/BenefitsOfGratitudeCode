using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Author: Gerald Anthony Jr
public class Mirror : MonoBehaviour
{
    
    public Text tutorialText;

    //Obstacles
    public GameObject obstacle_1;
    public GameObject obstacle_2;
    public GameObject obstacle_3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Move obstacles once mirror is interacted with
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            obstacle_1.GetComponent<Obstacle>().clearObstacle();
            obstacle_2.GetComponent<Obstacle>().clearObstacle();
            obstacle_3.GetComponent<Obstacle>().clearObstacle();

            tutorialText.text = "Now find the lever!";
        }
    }
}
