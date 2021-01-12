using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject gamePlayCanvas;
    public GameObject gameScoreCanvas;
    public GameObject player;
    
    public void Start()
    {
        Time.timeScale = 1;
    }

    public void Play()
    {
        gamePlayCanvas.SetActive(false);
        gameScoreCanvas.SetActive(true);
        player.SetActive(true);
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        gameScoreCanvas.SetActive(false);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene("GameReplay");
    }
}
