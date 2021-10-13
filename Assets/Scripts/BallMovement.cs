using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D Rb;
    public float speed = 400;

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        Rb.AddForce(new Vector2(20 * Time.deltaTime * speed, 20 * Time.deltaTime * speed));
    }
}
