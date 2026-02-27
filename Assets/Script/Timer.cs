using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private bool isRecord;
    [SerializeField] private float timerFloat;
    public Text timer, endTimer;

    private void Update()
    {
        if (isRecord)
        {
            timerFloat += Time.deltaTime;
            int min = (int)timerFloat / 60;
            float sec = timerFloat % 60;
            timer.text = min.ToString("00") + ":" +sec.ToString("00.00");
        }
    }

    public void timerStart()
    {
        isRecord = true;
        timer.gameObject.SetActive(true);
    }

    public void timerEnd()
    {
        isRecord = false;
        endTimer.text = timer.text;
    }
}
