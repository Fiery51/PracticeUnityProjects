using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D playerRb;
    
    // Jump Values
    public float jumpForce;
    public bool canDoubleJump = true;
    public int numberOfJumps = 0;

    // Move Values
    public float moveSpeed;
    public static Vector2 move;
    public float horizontalInput;


    void Start()
    {
        move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    void Update()
    {
        Move();
        Jump();
    }
    void Move()
    {
        if (horizontalInput < 0)
        {
            //transform.Translate()
        }
    }
    void Jump()
    {

    }
}
