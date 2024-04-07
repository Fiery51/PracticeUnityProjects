using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testingfile : MonoBehaviour
{
    public Rigidbody2D playerRb;
    public bool onGround = false;

    public Vector2 horizontal;
    public float movePower = 1.0f;
    public float jumpPower = 100f;
    
    void Start()
    {
        horizontal = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        gameObject.transform.Translate(horizontal * movePower * Time.deltaTime, 0);
    }

    void Jump()
    {
        if (Input.GetKeyDown("space") && onGround == true)
        {
            Debug.Log("jump uwu");
            playerRb.AddForce(new Vector2(0f, jumpPower));
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        onGround = true;
    }
}
