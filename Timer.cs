using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text timerTxt;
    private float startTime;
    private bool isTimerActive;
    // Start is called before the first frame update
    void Start()
    {
        StartTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimerActive)
        {
            float t = Time.time - startTime;

            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f2");

            timerTxt.text = minutes + ":" + seconds;
        }
    }

    private void StartTimer()
    {
        startTime = Time.time;
        isTimerActive = true;
    }
}
