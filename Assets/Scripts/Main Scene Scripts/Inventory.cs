using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//A data structure that represents the player's inventory
//Authors: Gerald Anthony, Jr.
//         Charlie Christakos
public class Inventory : MonoBehaviour
{
    //Array of items in inventory
    public Item[] items = new Item[8];
    //Array of inventory item ui images 
    public Sprite[] itemImgs = new Sprite[8];
    //Sprite for inventory
    public Sprite keySprite;
    //The number of items in the inventory
    public int numItems = 0;

    //The inventory UI slots
    public GameObject[] slots = new GameObject[8];
    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    public GameObject slot5;
    public GameObject slot6;
    public GameObject slot7;
    public GameObject slot8;

    // Start is called before the first frame update
    void Start()
    {
        slots[0] = slot1;
        slots[1] = slot2;
        slots[2] = slot3;
        slots[3] = slot4;
        slots[4] = slot5;
        slots[5] = slot6;
        slots[6] = slot7;
        slots[7] = slot8;
    }

    //puts an item in the inventory
    public void pickUpItem(Item item)
    {
        items[numItems] = item;
        itemImgs[numItems] = item.itemImage;
        slots[numItems].GetComponent<Image>().sprite = itemImgs[numItems];
        numItems++;
    }

    //removes an item from the inventory
    public void consumeItem(int index)
    {
        for (int i = index; i < 7; i++)
        {
            items[i] = items[i + 1];
            itemImgs[i] = itemImgs[i + 1];
            slots[i].GetComponent<Image>().sprite = slots[i + 1].GetComponent<Image>().sprite;
        }
        items[7] = null;
        itemImgs[7] = null;
        slots[7].GetComponent<Image>().sprite = null;
    }
}
