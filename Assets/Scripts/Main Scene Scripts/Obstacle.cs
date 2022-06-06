using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//a class of game objects which permanently move position after certain conditions are met
//Authors: Gerald Anthony, Jr.
//         Charlie Christakos
public class Obstacle : MonoBehaviour
{
    //the space the obstacle will move to after its move conditions are met
    public Transform nextPosition;
    //the speed at which the obstacle will move to point B
    public float moveSpeed = 5f;
    //bool determines whether obstacle should start moving
    public bool isMoving = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveObstacle();
    }

    public void moveObstacle()
    {
        //checks to see if obstacle should be moving
        if (Vector3.Distance(transform.position, nextPosition.position) >= 0.007f && isMoving == true)
        {
            //Move the obstacle from its current position to its next position based on where it is located now
            transform.position = Vector3.MoveTowards(transform.position, nextPosition.position, moveSpeed * Time.deltaTime);
        }
    }

    public void clearObstacle()
    {
        isMoving = true;
    }
}
