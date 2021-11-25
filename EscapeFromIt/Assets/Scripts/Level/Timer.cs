using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeValue = 90;

    public Text timeText;

    public bool isDead = false;

    public GameObject YouDied;

    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }

        else
        {
            timeValue = 0;
        }

        DisplayTime(timeValue);
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;


        }

        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("It's really hot now, dying in: {00} seconds", seconds);
    }

    void Dead()
    {
        isDead = true;

        if (isDead == true)
        {
            YouDied.SetActive(true);

        }
    }
}
