using UnityEngine;
using UnityEngine.InputSystem;


public class PaddleController : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    Vector2 direction;
    Rigidbody2D rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnMove(InputValue value)
    {
        direction = value.Get<Vector2>().normalized;
    }

    private void FixedUpdate()
    {
        rigidbody.velocity = direction * speed;
    }
}
