using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    //Components
    public Rigidbody2D playerRb;

    //Movement
    public Vector2 horizontal;
    public float movePower = 1.0f;
    public float jumpPower = 100f;
    public bool onGround = false;

    //Animation
    public float xScale;
    public float yScale;
   

    void Start()
    {
        horizontal = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        xScale = transform.localScale.x;
        Debug.Log("xScale = " + xScale);
        yScale = transform.localScale.y;
        Debug.Log("yScale = " + yScale);
    }

    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        float newHorizontal = Input.GetAxis("Horizontal");
        horizontal.x = newHorizontal;
        gameObject.transform.Translate(horizontal * movePower * Time.deltaTime, 0);
        //This changes the direction that the character looks based on its direction of movement
        if (newHorizontal > 0)
        {
            transform.localScale = new Vector2(xScale, yScale);
        }
        if (newHorizontal < 0)
        {
            transform.localScale = new Vector2(-xScale, yScale);
        }
        //Debug Logs
        if (newHorizontal > 0)
        {
            Debug.Log("Right");
        }
        if (newHorizontal < 0)
        {
            Debug.Log("Left");
        }
    }

    void Jump()
    {
        if (Input.GetKeyDown("space") && onGround == true)
        {
            Debug.Log("Jump");
            playerRb.AddForce(new Vector2(0f, jumpPower));
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        onGround = true;
    }
}
