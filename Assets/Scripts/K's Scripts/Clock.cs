using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clock : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public int time = 600;
    private bool secondAdded = false;
    public bool is24hTime = false;
    private int minute;
    private int hour;
    private string period;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 6;
        timeText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!secondAdded)
        {
            StartCoroutine(AddMinute());
        }

        if (hour > 11)
        {
            period = "PM";
        }
        else
        {
            period = "AM";
        }

        if (minute < 10)
        {
            timeText.text = hour + ":0" + minute + " " + period;
        }
        else
        {
            timeText.text = hour + ":" + minute + " " + period;
        }
        
    }

    IEnumerator AddMinute()
    {
        secondAdded = true;
        yield return new WaitForSeconds(1);
        time += 1;
        minute = time % 100;
        hour = time / 100;
        if (minute > 59)
        {
            minute = 0;
            hour += 1;
            time = 100 * hour;
        }
        secondAdded = false;

    }
}
