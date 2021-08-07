using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject finishPanel;
    public bool _isFinishGame = false;

    private ScoreManager _scoreManager;
    private FinishPanelManager _finishPanelManager;
    
    private int _counterBool = 0; // finishGame in bir kere calismasi icin.

    private void Awake()
    {
        _scoreManager = FindObjectOfType<ScoreManager>();
        _finishPanelManager = FindObjectOfType<FinishPanelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_isFinishGame && _counterBool == 0)
        {
            _counterBool++;
            FinishGame();
        }
        
    }

    private void FinishGame()
    {
        finishPanel.SetActive(true);
        UpdateBestScore();
        _finishPanelManager.SetGameInfo();
    }
    
    /**
     * Yeni score en yüksek scoredan büyük ise bestScore u günceller.
     */
    private void UpdateBestScore()
    {
        int bestScore = SaveSystem.LoadPlayer().bestScore;
        int newScore = _scoreManager.score;
        if (newScore > bestScore)
        {
            SaveSystem.SavePlayer(newScore);
        }
    }
    
    
}
