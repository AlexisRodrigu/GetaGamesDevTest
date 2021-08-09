using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIGame : MonoBehaviour
{
    [SerializeField] private CanvasGroup _canvasGroup;
    private UIGameMediator _uiGameMediator;

    [SerializeField] private TextMeshProUGUI timer;
    
    private bool raceHasStarted;
    public float timeRemaining = 10;

    // public float minutos;

    #region UNITY EVENTS
    private void Start()
    {
        raceHasStarted = true;
       
        // minutos = minutos * (60 / 1);
        // Debug.Log(minutos);
    }

    private void Update()
    { 
        StartRace();

    }
    

    #endregion
 

    public void Configure(UIGameMediator uiGameMediator)
    {
      _uiGameMediator = uiGameMediator;
    }


    private void StartRace()
    {
        if (raceHasStarted)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                raceHasStarted = false;
            }
        }
    }
    
    
    private void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
