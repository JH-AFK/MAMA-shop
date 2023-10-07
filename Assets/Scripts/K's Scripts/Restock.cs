using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restock : MonoBehaviour
{

    public AudioSource BGM;
    public AudioClip feedbackAudio;
    public GameObject menuPanel;

    void Start()
    {

    }

    void Update()
    {

    }

    public void RestockClicked()
    {
        if (!menuPanel.activeInHierarchy)
        {
            BGM.PlayOneShot(feedbackAudio);
            menuPanel.SetActive(true);
        }
        else
        {
            BGM.PlayOneShot(feedbackAudio);
            menuPanel.SetActive(true);
        }
    }

}
