using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class characterController2 : MonoBehaviour
{
    public float jumpForce = 130.0f;
    public float speed;
    private float moveDirection;

    private bool moving;
    private Rigidbody2D _rigidbody2D;
    private Animator anim;
    private SpriteRenderer _spriteRenderer;

    void Awake()
    {
        anim = GetComponent<Animator>();
        
    }

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    private void FixedUpdate()
    {
        if (_rigidbody2D.velocity != Vector2.zero)
        {
            moving = true;
        } else
        {
            moving = false;
        }

        _rigidbody2D.velocity = new Vector2(speed * moveDirection, _rigidbody2D.velocity.y);
        
    }
    private void Update()
    {
        // Get horizontal and vertical input separately
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        if (horizontalInput != 0)
        {
            moveDirection = horizontalInput;
            _spriteRenderer.flipX = horizontalInput < 0; // Flips based on direction
            anim.SetFloat("speed", Mathf.Abs(horizontalInput)); // Set speed based on absolute value
        }
        else
        {
            moveDirection = 0.0f; // No horizontal movement
        }

        if (verticalInput != 0)
        {
            transform.Translate(Vector3.up * verticalInput * speed * Time.deltaTime);

        }
    }


   
        
        
    
}
