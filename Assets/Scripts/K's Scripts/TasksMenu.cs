using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TasksMenu : MonoBehaviour
{
    public GameObject taskNotif;
    public TextMeshProUGUI taskNotifText;
    public int tasks;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (taskNotif.activeInHierarchy)
        {
            taskNotifText.text = tasks.ToString();
        }
    }
}
