using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrencyManager : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI gemsText;
    public int coins;
    public int gems;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = coins.ToString();
        gemsText.text = gems.ToString();

    }
}
