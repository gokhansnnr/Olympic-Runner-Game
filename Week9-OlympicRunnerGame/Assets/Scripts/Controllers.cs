using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class Controllers : MonoBehaviour
{
    public bool startTimer=false;
    public float timer, timeKeeper;
    public int ekstraTime;
    public TMP_Text timeText, addTime;

    private void Start()
    {
        timeKeeper = PlayerPrefs.GetInt("TimeKeeper", (int)timer);
    }

    private void Update()
    {
        PlayerPrefs.SetInt("TimeKeeper", (int)timer);
        timeText.text = "Left Time: " + timer;
        if (startTimer)
        {
            timer -= Time.deltaTime;
            timer = (int)timer;

            timer += ekstraTime;
            addTime.text = "+ " + ekstraTime;
            ekstraTime = 0;
        }
        else
        {
            timer = PlayerPrefs.GetInt("TimeKeeper", (int)timer);
            
        }
        


    }


}
