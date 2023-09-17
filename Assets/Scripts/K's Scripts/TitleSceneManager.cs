using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleSceneManager : MonoBehaviour
{
    public AudioSource BGM;
    public AudioClip clickSFX;
    public AudioClip meowSFX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButton()
    {
        ButtonClickFeedback();
        DisableButton();
    }
    
    public void SettingsButton()
    {
        ButtonClickFeedback();
        DisableButton();
    }

    public void CreditsButton()
    {
        ButtonClickFeedback();
        DisableButton();
    }

    public void QuitButton()
    {
        ButtonClickFeedback();
        DisableButton();
        Application.Quit(); //Will make the quitting better
    }

    void ButtonClickFeedback()
    {
        BGM.PlayOneShot(clickSFX);
        BGM.PlayOneShot(meowSFX);
    }

    void DisableButton() //prevents button from getting spammed after click
    {
        if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>().enabled)
        {
            EventSystem.current.currentSelectedGameObject.GetComponent<Button>().enabled = false;
        }
        
    }

}
