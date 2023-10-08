using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = ("Create Item"))]
public class ItemSO : ScriptableObject
{
    public string itemName;
    public string description;
    public Sprite image;
    public int cost;
    public int boxQuantity; //how many of the item you get per restock box
    public int boxes = 0;
    public int inventoryAmount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
