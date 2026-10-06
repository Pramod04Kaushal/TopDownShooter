using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

    private Vector2 moveInput;
    private int facingDirection = 1;

    void Update()
    {
        if(moveInput.x > .1f && facingDirection < 0 || moveInput.x < -.1f && facingDirection > 0)
        {
            Flip();
        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        rb.linearVelocity = moveInput * speed; 
        
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void Flip()
    {
        facingDirection *= -1;

        Vector3 scale = transform.localScale;
        scale.x = facingDirection;
        transform.localScale = scale;
    }
}
