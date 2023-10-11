using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clock : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public int time = 600; //actual time used
    private bool minuteAdded = false;
    public bool is24hTime = false;
    private int minute = 0; //for display only
    private int hour = 6; //for display only
    private string period; //for display only

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 6;
        timeText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!minuteAdded)
        {
            StartCoroutine(AddMinute());
        }

        if (is24hTime)
        {
            timeText.text = (hour > 9 ? hour.ToString() : "0" + hour) + " " + (minute < 10 ? "0" + minute : minute.ToString());
        }
        else
        {
            period = (hour > 11) ? period = "PM" : period = "AM";
            timeText.text = (hour > 12 ? (hour - 12).ToString() : hour.ToString()) + ":" + (minute < 10 ? "0" + minute : minute ) + " " + period;
        }
        
    }

    IEnumerator AddMinute()
    {
        minuteAdded = true;
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
        minuteAdded = false;

    }
}
