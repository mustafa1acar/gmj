using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeClock : MonoBehaviour
{
    public float totalSecond = 90;
    public Text clockText;
    void Start()
    {
        
    }

 
    void Update()
    {
        if (totalSecond > 0)
        {
            totalSecond -= Time.deltaTime;
        }
        else
        {
            totalSecond = 0;
            Debug.Log("sure bitti");
        }
        ShowTimeOnScreen(totalSecond);
    }
    void ShowTimeOnScreen(float timeDisplay)
    {
        if (timeDisplay < 0)
        {
            timeDisplay = 0;
        }
        float minutes = Mathf.FloorToInt(timeDisplay / 60);
        float second = Mathf.FloorToInt(timeDisplay % 60);

        clockText.text = string.Format("{0:00}:{1:00}", minutes, second);

    }
}
