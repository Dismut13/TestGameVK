using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using InstantGamesBridge;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text HighscoreText;

    public Ball ball;

    public Paddle playerPaddle;
    public int playerScore { get; private set; }
    public Text playerScoreText;

    public Paddle computerPaddle;
    public int computerScore { get; private set; }
    public Text computerScoreText;

    public GameObject HPanel;
    int highscore;

    public Text NameText;


    private void Start()
    {
        NewGame();

        Bridge.Initialize(isInitialized =>
        {
            if (isInitialized)
            {
                // Готово, можно продолжать. Например, загружать следующую сцену.
            }
            else
            {
                // Ошибка. Что-то пошло не так.
            }
        });
    }

    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.R)) {
          //  NewGame();
        //}

        highscore = (int)playerScore;

        if (PlayerPrefs.GetInt("playerScore") <= highscore)
        {
            PlayerPrefs.SetInt("playerScore", highscore);
        }

        HighscoreText.text = "Highscore: " + PlayerPrefs.GetInt("playerScore").ToString();

        if (computerScore >= 7)
        {
            Time.timeScale = 0;
            HPanel.SetActive(true);
        }
    }

    public void NewGame()
    {
        SetPlayerScore(0);
        SetComputerScore(0);
        StartRound();
        HPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void StartRound()
    {
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        ball.ResetPosition();
        ball.AddStartingForce();
    }

    public void PlayerScores()
    {
        SetPlayerScore(playerScore + 1);
        StartRound();
    }

    public void ComputerScores()
    {
        SetComputerScore(computerScore + 1);
        StartRound();
    }

    private void SetPlayerScore(int score)
    {
        playerScore = score;
        playerScoreText.text = score.ToString();
    }

    private void SetComputerScore(int score)
    {
        computerScore = score;
        computerScoreText.text = score.ToString();
    }

    public void Res()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }


    public void Nsc()
    {
        highscore ++;
    }
}
