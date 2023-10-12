using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TasksPanel : MonoBehaviour
{
    public CatSO selectedCat;
    public GameManager gm;
    public GameObject taskPanel;
    public string currentTask;
    public Image catHeadShot;
    public Image ItemRequest;
    public TextMeshProUGUI catName;
    public TextMeshProUGUI taskName;
    public TextMeshProUGUI taskDescription;
    public TextMeshProUGUI taskStatus;
    public TextMeshProUGUI taskReward;
    public AudioSource BGM;
    public AudioClip feedbackAudio;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (selectedCat) //will put in its own function as well
        {
            catHeadShot.enabled = true;
            catHeadShot.sprite = selectedCat.headShot;
            if (selectedCat.taskType == "Item")
            {
                ItemRequest.enabled = true;
                ItemRequest.sprite = selectedCat.requestedItemPic;
            }
            else
            {
                ItemRequest.enabled = false;
            }
            catName.text = selectedCat.catName;
            taskName.text = selectedCat.taskName;
            taskDescription.text = selectedCat.taskDescription;
            taskStatus.text = selectedCat.taskStatus;
            taskReward.text = selectedCat.taskReward;



        }
        else
        {
            
        } 
    }

    public void TaskMenuClicked()
    {
        if (!taskPanel.activeInHierarchy)
        {
            if (gm.activePanel)
            {
                gm.activeButton.GetComponent<Outline>().enabled = false;
                gm.activePanel.SetActive(false);
            }
            gameObject.GetComponent<Outline>().enabled = true;
            gm.activePanel = taskPanel;
            gm.activeButton = gameObject;
            BGM.PlayOneShot(feedbackAudio);
            taskPanel.SetActive(true);
        }
        else
        {
            gameObject.GetComponent<Outline>().enabled = false;
            gm.activePanel = null;
            gm.activeButton = null;
            BGM.PlayOneShot(feedbackAudio);
            taskPanel.SetActive(false);
        }
    }

    public void TaskClicked(CatSO cat)
    {
        BGM.PlayOneShot(feedbackAudio);
        selectedCat = cat;
    }
}
