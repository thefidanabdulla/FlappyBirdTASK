using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region
    public static GameManager instance = null;
    private void Awake()
    {
        if (instance == null) instance = this;
        else DontDestroyOnLoad(instance);
    }
    #endregion

    public int score;
    public bool isGameOver;
   
    public void ScoreE()
    {
        score++;
    }

    public void GameOver()
    {
        isGameOver= true;
        Time.timeScale= 0.0f;
    }

    public void StopGame()
    {
        Time.timeScale= 0.0f;
    }

    public void ContinueGame()
    {
        Time.timeScale= 1.0f;
    }

}
