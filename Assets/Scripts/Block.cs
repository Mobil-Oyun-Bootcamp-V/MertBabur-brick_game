using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Block : MonoBehaviour
{
    private int _hitsRemaining = 5;
    
    private SpriteRenderer _spriteRenderer;
    private TextMeshPro _text;

    // Start is called before the first frame update
    void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _text = GetComponentInChildren<TextMeshPro>();
        UpdateVisualState();
    }

    private void UpdateVisualState()
    {
        _text.SetText(_hitsRemaining.ToString());
        _spriteRenderer.color = Color.Lerp(Color.white, Color.red, _hitsRemaining / 10f);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        _hitsRemaining--;
        if(_hitsRemaining > 0)
            UpdateVisualState();
        else
            Destroy(gameObject);
    }
    
    internal void SetHits(int hits)
    {
        _hitsRemaining = hits;
        UpdateVisualState();
    }
    
}
