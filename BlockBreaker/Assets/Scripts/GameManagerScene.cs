using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerScene : GameManager
{
    private void Awake()
    {
        LoadHighScore();
        LoadCurrentScore();
    }
    private void Start()
    {
        UpdateScoreText();
        UpdateHighScoreText();
    }
}