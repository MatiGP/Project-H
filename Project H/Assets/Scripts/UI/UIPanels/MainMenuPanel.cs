using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI.UIPanels
{
    public class MainMenuPanel : UIPanel
    {
        public event Action OnPlayGame;
        public event Action OnExitGame;

        [SerializeField] private Button _playGameButton = null;
        [SerializeField] private Button _exitGameButton = null;

        private void Awake()
        {
            BindEvents();
        }

        private void OnDestroy()
        {
            UnBindEvents();
        }

        private void BindEvents()
        {
            _playGameButton.onClick.AddListener(HandlePlayButtonPressed);
            _exitGameButton.onClick.AddListener(HandleExitGameButtonPressed);
        }
        
        private void UnBindEvents()
        {
            _playGameButton.onClick.RemoveListener(HandlePlayButtonPressed);
            _exitGameButton.onClick.RemoveListener(HandleExitGameButtonPressed);
        }

        private void HandleExitGameButtonPressed()
        {
            OnPlayGame?.Invoke();
        }

        private void HandlePlayButtonPressed()
        {
            OnExitGame?.Invoke();
        }
    }
}
