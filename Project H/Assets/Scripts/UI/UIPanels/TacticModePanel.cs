using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI.UIPanels
{
    public class TacticModePanel : UIPanel
    {
        public event Action OnTacticModeFinished;

        [SerializeField] private Button _readyButton = null;

        private void Awake()
        {
            _readyButton.onClick.AddListener(HandleReadyButtonPressed);
        }

        private void OnDestroy()
        {
            _readyButton.onClick.RemoveListener(HandleReadyButtonPressed);
        }

        private void HandleReadyButtonPressed()
        {
            OnTacticModeFinished?.Invoke();
        }
        
        
    }
}
