﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReturn : MonoBehaviour
{
    private BallLauncher _ballLauncher;
    
    private void Awake()
    {
        _ballLauncher = FindObjectOfType<BallLauncher>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        _ballLauncher.ReturnBall();
        other.collider.gameObject.SetActive(false);
        if (other.gameObject.CompareTag("Block"))
        {
            Debug.Log("Bitti");
        }
    }
}
