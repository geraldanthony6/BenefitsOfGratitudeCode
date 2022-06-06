using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateRed : PressurePlate
{
    public GameObject square;

    public override void EventTrigger()
    {
        square.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 1);
    }
}
