using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public class UIManager : MonoBehaviour
    {
        public static UIManager Instance = null;

        [SerializeField] private Canvas _mainCanvas = null;

        private Dictionary<EPanelID, UIPanel> _existingPanels = null;
        private UIGlobalLayer _uiGlobalLayer = null;

        public void Initialize()
        {
            Instance = this;
            _existingPanels = new Dictionary<EPanelID, UIPanel>();
            _uiGlobalLayer = new UIGlobalLayer();
        }

        public UIPanel CreatePanel(EPanelID panelID)
        {
            if (_existingPanels.ContainsKey(panelID))
            {
                return _existingPanels[panelID];
            }

            string panelPath = panelID.ToPrefabPath();

            UIPanel loadedPanel = Instantiate(Resources.Load<UIPanel>(panelPath));
            loadedPanel.transform.SetParent(_mainCanvas.transform);
            loadedPanel.transform.localPosition = Vector3.zero;

            loadedPanel.SetID(panelID);
            loadedPanel.OnPanelClosed += HandlePanelClosed;

            Canvas panelCanvas = loadedPanel.GetComponent<Canvas>();
            panelCanvas.overrideSorting = true;
            panelCanvas.sortingOrder = _uiGlobalLayer.PanelOrder.IndexOf(panelID);

            return loadedPanel;
        }

        private void HandlePanelClosed(EPanelID closedPanelID)
        {
            _existingPanels.Remove(closedPanelID);
        }
    }
}
