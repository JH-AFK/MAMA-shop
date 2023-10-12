using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GachaPanel : MonoBehaviour
{
    public GameManager gm;
    public GameObject gachaPanel;
    public GameObject opening;
    public GameObject[] capsules;
    public AudioSource BGM;
    public AudioClip feedbackAudio;
    public TextMeshProUGUI skinChances;

    public Vector2[] initCapsulePos;
    // Start is called before the first frame update
    void Start()
    {
        initCapsulePos = new Vector2[capsules.Length];
        for (int i = 0; i < capsules.Length; i++)
        {
            initCapsulePos[i] = capsules[i].transform.position;
        }
    }
    void OnEnable()
    {
        if (initCapsulePos.Length > 0)
        {
            for (int i = 0; i < capsules.Length; i++)
            {
                capsules[i].transform.position = initCapsulePos[i];
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GachaButtonClicked()
    {

        for (int i = 0; i < capsules.Length; i++)
        {
            capsules[i].transform.position = initCapsulePos[i];
        }
        if (!gachaPanel.activeInHierarchy)
        {
            if (gm.activePanel)
            {
                gm.activeButton.GetComponent<Outline>().enabled = false;
                gm.activePanel.SetActive(false);
            }
            gameObject.GetComponent<Outline>().enabled = true;
            gm.activePanel = gachaPanel;
            gm.activeButton = gameObject;
            BGM.PlayOneShot(feedbackAudio);
            gachaPanel.SetActive(true);
        }
        else
        {
            gameObject.GetComponent<Outline>().enabled = false;
            BGM.PlayOneShot(feedbackAudio);
            gachaPanel.SetActive(false);
        }
    }

    public void GachaMachineClicked()
    {
        opening.SetActive(false);
    }

}
