using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace UI.UIPanels
{
    public class SplashScreenPanel : UIPanel
    {
        public event Action OnFadeCompleted;
        
        [SerializeField] private float _fadeDuration = 1.2f;

        private void Start()
        {
            // TODO: Improve this.
            _canvasGroup.DOFade(1, _fadeDuration).OnComplete(
                () => _canvasGroup.DOFade(0, _fadeDuration)
                    .OnComplete(() =>
                    {
                        OnFadeCompleted?.Invoke();
                        Close();
                    })
                );
        }
    }
}
