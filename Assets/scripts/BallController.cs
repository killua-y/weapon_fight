using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    public int health;
    public int attack;
    private int currentHealth;
    private int maxHealth;
    public Slider healthSlider;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Random.insideUnitCircle.normalized * speed;
        //healthSlider.maxValue = maxHealth;
        //healthSlider.value = currentHealth;
    }

    void FixedUpdate()
    {
        rb.velocity = rb.velocity.normalized * speed;
    }

    public void takeDamage(int amount)
    {
        currentHealth -= amount;
        //healthSlider.value = currentHealth;
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
