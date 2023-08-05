using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float rotationAmount;
    private float horizontalInput;

    private bool isRotated;
    private bool isOnGround;
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");

        //Rotates the player right
        if (horizontalInput == -1 && !isRotated)
        {
            transform.Rotate(Vector3.up * rotationAmount);
            isRotated = true;
        }
        //Rotates the player right
        if (horizontalInput == 1 && isRotated)
        {
            transform.Rotate(Vector3.up * -rotationAmount);
            isRotated = false;
        }

        //Allows player to jump if on ground with space key
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isOnGround = false;
        }
    }

    private void FixedUpdate()
    {
        //Allows the player to move in the horizontal axis
        rb.velocity = new Vector2(horizontalInput * speed * Time.deltaTime, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOnGround = true;
    }
}
