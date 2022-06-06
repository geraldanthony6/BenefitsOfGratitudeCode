using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareGreen : Square
{
    public GameObject square;

    public override void EventTrigger()
    {
        square.GetComponent<SpriteRenderer>().color = new Color(0, 1, 0, 1);
    }
}
