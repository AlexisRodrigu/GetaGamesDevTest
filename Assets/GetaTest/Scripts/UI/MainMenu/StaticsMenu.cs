using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class StaticsMenu : MonoBehaviour
{
    private MenuMediator _menuMediator;
    [SerializeField] private CanvasGroup _canvasGroup;
    [SerializeField] private Button _returnButton;

    private void Awake()
    {
        _returnButton.onClick.AddListener(()=>_menuMediator.MoveToMainMenu());

    }

    public void Configure(MenuMediator menuMediator)
    {
        _menuMediator = menuMediator;
    }

    public void Hide()
    {
        //importamos libreria tweening, hacemos un fade para esconder
        _canvasGroup.DOFade(0.0f, 0.5f);
    }

    public void Show()
    {
        _canvasGroup.DOFade(1.0f, 0.5f);
    }
}
