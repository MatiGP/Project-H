using System;
using System.Collections;
using System.Collections.Generic;
using Core.StateMachine;
using Core.StateMachine.States;
using UI;
using UnityEngine;

public class GameApp : MonoBehaviour
{
    public static GameApp Instance = null;

    public LevelLoader LevelLoader => _levelLoader;
    
    [SerializeField] private UIManager _uiManager = null;
    [SerializeField] private EAppState _startingState = EAppState.Intro;

    private StateMachine _menuStateMachine = null;
    private LevelLoader _levelLoader = null;
    
    private void Awake()
    {
        Instance = this;
        InitializeSubSystems();
        CreateStates();
        StartStateMachine();
    }
    
    private void InitializeSubSystems()
    {
        _menuStateMachine = new StateMachine();
        _levelLoader = new LevelLoader();
        
        _menuStateMachine.Initialize();
        _uiManager.Initialize();
    }

    private void StartStateMachine()
    {
        _menuStateMachine.SwitchToState((int)_startingState);
    }

    private void CreateStates()
    {
        _menuStateMachine.AddState(new IntroState((int)EAppState.Intro, _menuStateMachine));
        _menuStateMachine.AddState(new MenuState((int)EAppState.Menu, _menuStateMachine));
        _menuStateMachine.AddState(new GameState((int)EAppState.Game, _menuStateMachine));
    }
}
