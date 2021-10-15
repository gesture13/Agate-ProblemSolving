using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D Rb;
    public float speed = 10f;

    private float horizontalAxis;
    private float verticalAxis;

    private void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        GetAxis();
    }

    private void FixedUpdate()
    {
        MoveTo();
    }

    // menggerakkan pemain ke arah vector (1,1)
    private void MoveTo()
    {
        Vector2 playerMovement = new Vector2(horizontalAxis, verticalAxis);

        Rb.velocity = playerMovement * speed;
    }

    private void GetAxis()
    {
        horizontalAxis = Input.GetAxis("Horizontal");
        verticalAxis = Input.GetAxis("Vertical");

        Debug.Log(horizontalAxis + "," + verticalAxis);
    }
}
