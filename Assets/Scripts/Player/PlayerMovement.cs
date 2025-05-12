using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get input in 4 directions (WASD or arrow keys)
        movement.x = Input.GetAxisRaw("Horizontal"); // -1, 0, or 1
        movement.y = Input.GetAxisRaw("Vertical");   // -1, 0, or 1  
        movement.Normalize();      
    }
    void FixedUpdate()
    {
        rb.linearVelocity = movement * moveSpeed;
    }

}
