using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RestockPanel : MonoBehaviour
{
    public ItemSO currentItem;
    public TextMeshProUGUI itemDescription;
    public Image itemImage;
    public AudioSource BGM;
    public AudioClip feedbackAudio;
    public GameObject restockPanel;
    public GameObject buyPanel;

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
        }
    }

    public void RestockClicked()
    {
        if (!restockPanel.activeInHierarchy)
        {
            BGM.PlayOneShot(feedbackAudio);
            restockPanel.SetActive(true);
        }
        else
        {
            BGM.PlayOneShot(feedbackAudio);
            restockPanel.SetActive(false);
        }
    }
    

    public void ItemClicked(ItemSO item)
    {
        BGM.PlayOneShot(feedbackAudio);
        currentItem = item;
    }

}
