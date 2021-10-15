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
        if (Input.GetMouseButtonDown(0))
        {
            GetAxis();
        }
    }

    private void FixedUpdate()
    {
        MoveTo();
    }

    // menggerakkan pemain ke arah vector (1,1)
    private void MoveTo()
    {
        Vector2 moveDirection = new Vector2(horizontalAxis, verticalAxis);

        Rb.position = Vector2.MoveTowards(transform.position,
            moveDirection, speed * Time.fixedDeltaTime);
    }

    private void GetAxis()
    {
        Vector2 currentMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        horizontalAxis = currentMousePosition.x;
        verticalAxis = currentMousePosition.y;
    }
}
