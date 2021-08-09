using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGameMediator : MonoBehaviour
{
    
    [SerializeField] private UIGame _uiGame;


    private void Awake()
    {
        _uiGame.Configure(this);
    }
}
