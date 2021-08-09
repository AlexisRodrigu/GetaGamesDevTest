using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    private MenuMediator _menuMediator;
    
    [SerializeField] private CanvasGroup _canvasGroup;
    [SerializeField] private Button _startRaceButton;
    [SerializeField] private Button _staticsButton;
    [SerializeField] private Button _exitGameButton;

    private void Awake()
    {
        _startRaceButton.onClick.AddListener(()=>_menuMediator.StartRace());
        _staticsButton.onClick.AddListener(()=>_menuMediator.MoveToStaticsMenu());
        _exitGameButton.onClick.AddListener(()=>_menuMediator.ExitGame());
    }

    public void Configure(MenuMediator menuMediator)
    {
        _menuMediator = menuMediator;
        
    }
    public void Hide()
    {
        _canvasGroup.DOFade(0.0f, 0.5f);
    }

    public void Show()
    {
        _canvasGroup.DOFade(1.0f, 0.5f);
    }
}
