using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] private Transform ballReturn;
    private float gameFinishDistance = 2f;
    
    private int _hitsRemaining = 5;
    
    private SpriteRenderer _spriteRenderer;
    private TextMeshPro _text;

    private GameManager _gameManager;

    // Start is called before the first frame update
    void Awake()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _text = GetComponentInChildren<TextMeshPro>();
        UpdateVisualState();
    }

    private void Update()
    {
        SetGameFinish();
    }

    /**
     * Küplerin görünüşlerini güncelleme
     */
    private void UpdateVisualState()
    {
        _text.SetText(_hitsRemaining.ToString());
        _spriteRenderer.color = Color.Lerp(Color.white, Color.red, _hitsRemaining / 10f);
    }

    /**
     * Toplar küplere çarptıkça oluşacak değişimler
     */
    private void OnCollisionEnter2D(Collision2D other)
    {
        _hitsRemaining--;
        if(_hitsRemaining > 0)
            UpdateVisualState();
        else
            Destroy(gameObject);
    }
    
    /**
     * Küplere çarptığında hitler set edilir
     */
    internal void SetHits(int hits)
    {
        _hitsRemaining = hits;
        UpdateVisualState();
    }

    /**
     * BallReturn ile son küp arasında uzaklığa göre oyunu bitirir
     */
    private void SetGameFinish()
    {
        float distance = Vector2.Distance(transform.position, ballReturn.position);
        Debug.Log(distance);
        if (distance < gameFinishDistance)
        {
            _gameManager._isFinishGame = true;
        }

    }
    
}
