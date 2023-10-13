using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleSceneManager : MonoBehaviour
{
    public GameObject[] canvases; //0 - Options Canvas, 1 - Credits Canvas
    public AudioSource BGM;
    public AudioClip clickSFX;
    public AudioClip meowSFX;
    private GameObject activeCanvas;
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
        SceneManager.LoadScene("MainScene");
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
        canvases[1].SetActive(true);
        activeCanvas = canvases[1];
    }

    public void QuitButton()
    {
        ButtonClickFeedback();
        DisableButton();
        Application.Quit(); //Will make the quitting better
    }

    public void BackToMenu()
    {
        ButtonClickFeedback();
        if (activeCanvas)
        {
            activeCanvas.SetActive(false);
        }
        else
        {
            for (int i = 0; i < canvases.Length; i++)
            {
                canvases[i].SetActive(false);
            }
        }
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
