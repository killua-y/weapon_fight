using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Random.insideUnitCircle.normalized * speed;
    }

    void FixedUpdate()
    {
        rb.velocity = rb.velocity.normalized * speed;
    }

    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Ball"))
    //    {
    //        Vector2 normal = collision.contacts[0].normal;
    //        Vector2 reflectedVelocity = Vector2.Reflect(rb.velocity, normal).normalized * speed;
    //        rb.velocity = reflectedVelocity;
    //    }
    //}
}
