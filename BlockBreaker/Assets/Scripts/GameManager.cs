using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform ballSpawn;
    public GameObject[] lifeSprites;
    private int life = 3;

    private void Start()
    {
        SpawnBall();
    }

    private void SpawnBall()
    {
        //오브젝트, 위치, 회전
        GameObject go = Instantiate(ballPrefab, transform.position, Quaternion.identity);
        //Instantiate(ballPrefab, ballSpawn.position, Quaternion.identity);
    }

    public void Health()
    {
        life--;
        UpdateLife();

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
