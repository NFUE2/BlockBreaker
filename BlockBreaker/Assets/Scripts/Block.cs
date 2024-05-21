using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    //[SerializeField] BlockSO blockSO;
    enum Blokenable
    {
        able,
        nope
    }

    [SerializeField] Blokenable blokenable; //�ν������ִ°�? �⺻������ �ν������ְ� ����
    [SerializeField] int blokenCount; //������� ����������
    Item item = null; //���� �������� ������ ������

    private void Awake()
    {
        item = GetComponent<Item>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (blokenable != 0) return;

        if(--blokenCount <= 0)
        {
            if(item != null) item.Active();
            gameObject.SetActive(false);
        }
    }
}
