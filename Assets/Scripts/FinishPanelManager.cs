using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishPanelManager : MonoBehaviour
{
    [SerializeField] private GameObject finishPanel;

    [SerializeField] private Text bestScoreText;
    [SerializeField] private Text scoreText;

    private LevelManager _levelManager;
    private ScoreManager _scoreManager;

    private void Awake()
    {
        _levelManager = FindObjectOfType<LevelManager>();
        _scoreManager = FindObjectOfType<ScoreManager>();
        
    }

    public void RetryGame()
    {
        _levelManager.RestartScene();
    }

    /**
     * Gerekli bilgileri ilgili uilara yerlestirir
     */
    public void SetGameInfo()
    {
        scoreText.text = _scoreManager.score.ToString();
        bestScoreText.text = SaveSystem.LoadPlayer().bestScore.ToString();
    }

    
   
}
