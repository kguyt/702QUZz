using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;
    public float hp = 10;
    private float moveInput;
    private Rigidbody2D rb;
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveInput = Input.GetAxis("Horizontal"); 
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }
}
