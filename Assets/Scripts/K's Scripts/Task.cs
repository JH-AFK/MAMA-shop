using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Task : MonoBehaviour
{
    public CatSO cat;
    private TextMeshProUGUI buttonText;
    // Start is called before the first frame update
    void Start()
    {
        buttonText = GetComponentInChildren<TextMeshProUGUI>();
        buttonText.text = cat.taskName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
