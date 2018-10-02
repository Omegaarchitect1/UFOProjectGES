using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    private int count;
    public Text CountText;
    public Text WinText;

    public float speed;

    private Rigidbody2D rb2d;

    private void Start()
    {
        count = 0;
        rb2d = GetComponent<Rigidbody2D>();
        WinText.text = "";
        SetCountText();
    }

 
    private void FixedUpdate()
    {
        float movementhorizontal = Input.GetAxis("Horizontal");
        float movementvertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(movementhorizontal, movementvertical);
        rb2d.AddForce(movement * speed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        CountText.text = "Count: " + count.ToString();
        if(count >= 10)
        {
            WinText.text = "You Win!";
        }
    }



}