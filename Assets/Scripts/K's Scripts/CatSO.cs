using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Cat", menuName = ("Create Cat"))]
public class CatSO : ScriptableObject
{
    public string catName;
    public string taskName;
    public string taskType;
    public string requestedItem; // for tasks
    public string dialogue;
    public string taskDescription;
    public string taskReward;
    public string taskStatus;
    public int numOfRequestedItems;
    public Sprite fullCat; //for shop activities
    public Sprite requestedItemPic;
    public Sprite headShot; //for dialogue
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
