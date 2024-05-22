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

    [SerializeField] Blokenable blokenable; //�ν������ִ°�? �⺻������ �ν������ְ� ����
    [SerializeField] int blokenCount; //������� ����������
    [SerializeField] GameObject item = null; //���� �������� ������ ������

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
