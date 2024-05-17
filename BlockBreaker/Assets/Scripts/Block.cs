using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] BlockSO blockSO;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (blockSO.blokenable != 0) return;

        if(--blockSO.blokenCount <= 0)
        {
            Instantiate(blockSO.item);
            Destroy(gameObject);
        }
    }
}
