using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    /**
     * Sahneyi yeniden başlatır
     */
    public void RestartScene()
    {
        LoadScene(GetActiveSceneIndex());
    }
    
    /**
     * Sahne yükleme
     */
    private void LoadScene(int buildIndexxx)
    {
        SceneManager.LoadScene(buildIndexxx);
    }

    /**
     * Aktif sahneyi getirir
     */
    public int GetActiveSceneIndex()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }
}
