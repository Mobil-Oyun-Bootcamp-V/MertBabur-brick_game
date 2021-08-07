using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Text scoreText;

    [SerializeField] public int score = 0;
    
    /**
     * Her adımdan sonra skoru günceller
     */
    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "TOP : " + score.ToString("N0");
    }
}
