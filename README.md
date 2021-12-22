# RunnerGame
 # *Flowchart*
 ![Flowchart](https://github.com/Rasyad-kun/RunnerGame/blob/master/Runner%20Flowchart.png)
 # *Documentation*
 ## *GameManager.cs*
 ### *void start() and update()*
  ```cpp
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
  ```
  **in this code we will make a starting menu**<br>
  `Time.timeScale = 0;` to pause while game is start.<br>
  `if (Input.GetMouseButtonDown(0))` for sign if player want to start a game in that mean 'when player click mouse button'.<br>
  to make sure the timeScale will not repeated when the player click the mouse button, we use `if (key == false)` as key, of course before that we set the key is true.<br>
  `Time.timeScale = 1;` to running game.<br>
  ` gameStartCanvas.SetActive(false);` to hide the start UI and `gameScoreCanvas.SetActive(true);` to appear the score UI.<br>
  `GenerateLevel.creatingSection = false;` to start the creating random map, creatingSection is key to make looping in GenerateLevel.cs<br>
  don't forget to set `key = true;` so that this program doesn't repeat.
 
 ### *void GameOver()*
 ```cpp
 //UI when the player loses the game
    public void GameOver()
    {
        gameOverFX.Play();//play game over sfx
        gameScoreCanvas.SetActive(false);
        scoreCountTXT.text = "Total Score : " + CollectControl.scoreCount;
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
 ```
 **in this code we will make a starting menu**<br>
 *void Gameover()* will called if player crash the dead object tagged.<br>
 `gameOverFX.Play();` to play the gameOverFX.<br>
 `gameScoreCanvas.SetActive(false);` to hide the score UI.<br>
 `scoreCountTXT.text = "Total Score : " + CollectControl.scoreCount;` to get the final value in variable score count and displayed in gameOverCanvas.<br>
 `gameOverCanvas.SetActive(true);` to appear the game over UI.<br>
 don't forget to set `Time.timeScale = 0;`  so that this game will pause.
 
 ### *void Replay()*
 ```cpp
 //to restart game if player click the replay button
    public void Replay()
    {
        CollectControl.scoreCount = 0;// to reset the score
        SceneManager.LoadScene(0);
    }
 ```
 **in this code we will make a starting menu**<br>
 *void Replay()* will called if player click the replay button in game over UI.<br>
 `CollectControl.scoreCount = 0;` to reset the point, in the future this can be developed, like the highest score.<br>
 `SceneManager.LoadScene(0);` to go back to the beginning, this proggram can we access if we include `using UnityEngine.SceneManagement;`<br>
 
