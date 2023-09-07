using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridElement : MonoBehaviour
{
    public Action<Vector3> OnSelect;


    [SerializeField] private SpriteRenderer _spriteRenderer = null;
    
    [SerializeField] private Sprite _hoverSprite = null;
    [SerializeField] private Sprite _defaultSprite = null;

    private void OnMouseEnter()
    {
        _spriteRenderer.sprite = _hoverSprite;
    }

    private void OnMouseExit()
    {
        _spriteRenderer.sprite = _defaultSprite;
    }

    private void OnMouseUp()
    {
        OnSelect?.Invoke(transform.position);
    }
}
