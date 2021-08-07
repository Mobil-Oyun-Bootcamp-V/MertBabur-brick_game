using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartPanelManager : MonoBehaviour
{
    [SerializeField] private GameObject startPanel;
    [SerializeField] private Text bestScoreText;

    private void Awake()
    {
        SetGameInfo();
    }
    
    /**
     * Oyunu baslatir
     */
    public void StartGame()
    {
        CloseStartPanel();
    }

    /**
     * Oyun başladığında paneli kapatır.
     */
    private void CloseStartPanel()
    {
        startPanel.SetActive(false);
    }

    /**
     * Oyun bilgilerini gerekli uilara yerlestirir
     */
    private void SetGameInfo()
    {
        bestScoreText.text = "BEST SCORE : " + SaveSystem.LoadPlayer().bestScore.ToString();
    }
    
}
