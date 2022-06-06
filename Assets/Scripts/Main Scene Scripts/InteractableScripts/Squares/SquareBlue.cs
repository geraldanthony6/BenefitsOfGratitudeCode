using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareBlue : Square
{
    public GameObject square;

    public override void EventTrigger()
    {
        square.GetComponent<SpriteRenderer>().color = new Color(0, 0, 1, 1);
    }
}
