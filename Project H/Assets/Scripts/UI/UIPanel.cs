using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    [RequireComponent(typeof(CanvasGroup))]
    public abstract class UIPanel : MonoBehaviour
    {
        public event Action<EPanelID> OnPanelClosed;

        [SerializeField] protected CanvasGroup _canvasGroup = null;

        private EPanelID _panelID = EPanelID.None;

        public void SetID(EPanelID panelID)
        {
            _panelID = panelID;
        }

        public virtual void Hide()
        {
            _canvasGroup.alpha = 0f;
            _canvasGroup.interactable = false;
            _canvasGroup.blocksRaycasts = false;
        }

        public virtual void Show()
        {
            _canvasGroup.alpha = 1f;
            _canvasGroup.interactable = true;
            _canvasGroup.blocksRaycasts = true;
        }

        public virtual void Close()
        {
            OnPanelClosed?.Invoke(_panelID);
            Destroy(gameObject);
        }
    }
}
