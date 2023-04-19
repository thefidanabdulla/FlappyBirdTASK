using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverSprite;
    [SerializeField] GameObject GetReadySprite;
    [SerializeField] GameObject ScoreSprite;
    [SerializeField] GameObject PlayButtonSprite;
    [SerializeField] GameObject RestartButtonSprite;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.StopGame();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.isGameOver)
        {
            gameOverSprite.SetActive(true);
        }
    }
    public void StartGame()
    {
        RestartButtonSprite.SetActive(true);
        ScoreSprite.SetActive(true);
        PlayButtonSprite.SetActive(false);
        GetReadySprite.SetActive(false);
        GameManager.instance.ContinueGame();
    }
    public void RestartTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
