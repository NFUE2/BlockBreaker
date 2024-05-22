using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score;
    public Text scoreText;

    public int highScore;
    public Text highScoreText;

    public GameObject ballPrefab;
    public Transform ballSpawn;
    public GameObject[] lifeSprites;
    public List<GameObject> balls { get; set; }
    private int life = 3;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        LoadHighScore();
    }

    private void Start()
    {
        balls = new List<GameObject>();
        SpawnBall();
        UpdateScoreText();
        UpdateHighScoreText();
    }
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
        SaveCurrentScore();

        if (score >= highScore)
        {
            highScore = score;
            UpdateHighScoreText();
            SaveHighScore();
        }
    }

    protected void UpdateScoreText()
    {
        scoreText.text = "" + score;
    }
    protected void UpdateHighScoreText()
    {
        highScoreText.text = "" + highScore;
    }

    protected void LoadHighScore()
    {
        highScore = PlayerPrefs.GetInt("HighScore");
    }
    protected void LoadCurrentScore()
    {
        score = PlayerPrefs.GetInt("CurrentScore", 0);
    }


    protected void SaveHighScore()
    {
        PlayerPrefs.SetInt("HighScore", highScore);
        PlayerPrefs.Save();
    }
    protected void SaveCurrentScore()
    {
        PlayerPrefs.SetInt("CurrentScore", score);
        PlayerPrefs.Save();
    }


    private void SpawnBall()
    {
        //오브젝트, 위치, 회전
        GameObject ball = Instantiate(ballPrefab, transform.position, Quaternion.identity);
        balls.Add(ball);
        //Instantiate(ballPrefab, ballSpawn.position, Quaternion.identity);
    }

    public void Health(GameObject ball)
    {
        //life--;
        balls.Remove(ball);

        if(balls.Count == 0)
        {
            life--;
            UpdateLife();
        }

        if (life <= 0)
        {
            GameOver();
        }
        else
        {
            //공이 사라지면 1초 뒤에 다시 생성
            Invoke("SpawnBall", 1f);
        }
    }

    private void UpdateLife()
    {
        for (int i = 0; i < lifeSprites.Length; i++)
        {
            lifeSprites[i].SetActive(i < life);
        }
    }

    private void GameOver()
    {
        SceneManager.LoadScene("Moon_EndScene");
    }
}