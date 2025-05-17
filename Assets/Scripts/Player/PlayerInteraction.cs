using System;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float checkDistance = 1f;
    public float checkRadius = 0.3f;
    public LayerMask interactableLayer; // assigning in the inspector, items to interact with will be of this layer

    private Vector2 facingDirection = Vector2.down; // Default
    public static Action<GameObject> OnInteract;

    void Update()
    {
        // Update facing direction based on input (WASD or arrow keys)
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector2 input = new Vector2(horizontal, vertical);

        if (input != Vector2.zero) // if no movement, keep last direction
        {
            facingDirection = input.normalized;
        }

        // Optional: Detect on key press
        if (Input.GetKeyDown(KeyCode.E))
        {
            TryInteract();
        }

    }

    void TryInteract()
    {
        Vector2 checkPosition = (Vector2)transform.position + facingDirection * checkDistance;

        Collider2D hit = Physics2D.OverlapCircle(checkPosition, checkRadius, interactableLayer);
        if (hit != null)
        {
            Debug.Log("Detected: " + hit.name);
            hit.GetComponent<InteractableInterface>()?.Interact();
        }
        else
        {
            Debug.Log("hit is null");
        }
    }


}

