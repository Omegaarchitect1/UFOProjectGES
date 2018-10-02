using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

 
    private void FixedUpdate()
    {
        float movementhorizontal = Input.GetAxis("Horizontal");
        float movementvertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(movementhorizontal, movementvertical);
        rb2d.AddForce(movement * speed);
    }

    
}