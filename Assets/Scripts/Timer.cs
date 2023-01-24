using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text timerText;
    private float startTimer;
    private bool stopTimer;

    public void Stop()
    {
        stopTimer = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponentInChildren<Text>();

        startTimer = 60;

        stopTimer = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Text timerText = GetComponent<Text>();

        if(startTimer > 0 && stopTimer == true)
        {
            startTimer -= Time.deltaTime;
        }
        else if(stopTimer == true)
        {
            GameObject.Find("GameController").GetComponent<GameController>().Creared();
        }

        timerText.text = "Žc‚èŽžŠÔ:" + startTimer.ToString();
    }
}
