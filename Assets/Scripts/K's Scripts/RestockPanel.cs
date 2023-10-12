using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RestockPanel : MonoBehaviour
{
    public ItemSO currentItem;
    public GameManager gm;
    public TextMeshProUGUI itemDescription;
    public TMP_InputField enterAmmountText;
    public Image itemImage;
    public AudioSource BGM;
    public AudioClip feedbackAudio;
    public GameObject restockPanel;
    public GameObject buyPanel;
    public float amount;
    public string inital;

    void Start()
    {

    }

    void Update()
    {
        if (currentItem)
        {
            itemImage.enabled = true;
            buyPanel.SetActive(true);
            itemDescription.text = currentItem.description;
            itemImage.sprite = currentItem.image;
        }
        else
        {
            itemImage.enabled = false;
            buyPanel.SetActive(false);
        }//this should be made a function and not put in an update but it is fine where it is rn
    }

    public void RestockClicked()
    {
        if (!restockPanel.activeInHierarchy)
        {
            if (gm.activePanel)
            {
                gm.activeButton.GetComponent<Outline>().enabled = false;
                gm.activePanel.SetActive(false);
            }
            gameObject.GetComponent<Outline>().enabled = true;
            gm.activePanel = restockPanel;
            gm.activeButton = gameObject;
            BGM.PlayOneShot(feedbackAudio);
            restockPanel.SetActive(true);
        }
        else
        {
            gameObject.GetComponent<Outline>().enabled = false;
            gm.activeButton = null;
            gm.activePanel = null;
            BGM.PlayOneShot(feedbackAudio);
            restockPanel.SetActive(false);
        }
    }
    

    public void ItemClicked(ItemSO item)
    {
        BGM.PlayOneShot(feedbackAudio);
        currentItem = item;
    }

    public void OnTyped(TextMeshProUGUI startingText)
    {
        inital = startingText.text;
        startingText.text = string.Empty;
    }

    public void OnReleased(TextMeshProUGUI startingText)
    {
        if(int.TryParse(enterAmmountText.text,out int result))
        {
            amount = result;
        }
        else
        {
            Debug.Log("pls input numbers, not letters");
            startingText.text = inital;
            enterAmmountText.text = string.Empty;
        }
    }
}
