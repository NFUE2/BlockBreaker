using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private GameManager gameManager;
    private Rigidbody2D rb;

    public float speed;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * speed;
        Debug.Log(speed);
    }

    private void Update()
    {
        if (transform.position.y < -6f)
        {
            gameManager.Health();
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            float paddleWidth = collision.collider.bounds.size.x;
            float hitPosition = (transform.position.x - collision.transform.position.x) / paddleWidth;

            Vector2 direction = new Vector2(hitPosition, 1).normalized;
            rb.velocity = direction * speed;
        }
        else
        {
            rb.velocity = rb.velocity.normalized * speed;
        }
    }
}
