using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject ballPrefab;
    public Transform ballSpawn;
    public GameObject[] lifeSprites;
    public List<GameObject> balls { get; set; }
    private int life = 3;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        balls = new List<GameObject>();
        SpawnBall();
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

        if(balls.Count == 0) UpdateLife();

        if(life <= 0 )
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
        for( int i = 0; i < lifeSprites.Length; i++ )
        {
            lifeSprites[i].SetActive(i < life);
        }
    }

    private void GameOver()
    {
        SceneManager.LoadScene("Moon_EndScene");
    }
}
