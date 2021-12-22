using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioSource gameOverFX;
    public GameObject gameOverCanvas;
    public GameObject gameStartCanvas;
    public GameObject gameScoreCanvas;
    public Text scoreCountTXT;
    public bool key = false;

    private void Start()
    {
        //pause at start for menu
        Time.timeScale = 0;
    }

    void Update()
    {
        //key to Start the game
        if (key == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Time.timeScale = 1;
                gameStartCanvas.SetActive(false);// hide the start UI
                gameScoreCanvas.SetActive(true);// Display the Score UI
                GenerateLevel.creatingSection = false;// start to generate terrain
                key = true;
            }
        }
    }

    //UI when the player loses the game
    public void GameOver()
    {
        gameOverFX.Play();//play game over sfx
        gameScoreCanvas.SetActive(false);
        scoreCountTXT.text = "Total Score : " + CollectControl.scoreCount;
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    //to restart game if player click the replay button
    public void Replay()
    {
        CollectControl.scoreCount = 0;// to reset the score
        SceneManager.LoadScene(0);
    }
}
