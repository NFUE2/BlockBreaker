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
        //������Ʈ, ��ġ, ȸ��
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
            //���� ������� 1�� �ڿ� �ٽ� ����
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
