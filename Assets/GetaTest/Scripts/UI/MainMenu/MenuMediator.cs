using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMediator : MonoBehaviour
{
    [SerializeField] private MainMenu _mainMenu;
    [SerializeField] private StaticsMenu _staticsMenu;

    private void Awake()
    {
        _mainMenu.Configure(this);
        _staticsMenu.Configure(this);
    }

    public void StartRace()
    {
        SceneManager.LoadScene("TrackScene");
    }

    public void MoveToStaticsMenu()
    {
        _mainMenu.Hide();
        _staticsMenu.Show();
    }

    public void MoveToMainMenu()
    {
        _mainMenu.Show();
        _staticsMenu.Hide();
    }

    public void ExitGame()
    {
        Debug.Log("EXIT");
        Application.Quit();
    }
}

