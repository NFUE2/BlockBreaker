using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block : MonoBehaviour
{
    public int points = 10;

    //[SerializeField] BlockSO blockSO;
    enum Blokenable
    {
        able,
        nope
    }

    [SerializeField] Blokenable blokenable; //부숴질수있는가? 기본적으로 부숴질수있게 설정
    [SerializeField] int blokenCount; //몇번만에 깨질것인지
    [SerializeField] GameObject item = null; //벽돌 깨졌을때 생성될 아이템

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (blokenable != 0) return;

        if(--blokenCount <= 0)
        {
            if(item != null) Instantiate(item);
            GameManager.instance.AddScore(points);
            gameObject.SetActive(false);
        }
    }

}
