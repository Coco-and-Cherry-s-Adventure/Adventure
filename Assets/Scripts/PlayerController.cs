using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D body;
    //movement
    [SerializeField] private float speed;
    private bool grounded;
    private int jumpCount = 0;
    private int maxJumps = 1;
    //health
    public int maxHealth = 10;
    int currentHealth;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        currentHealth = 0;
    }

    void Update()
    {
        body.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < maxJumps)
            Jump();
    }

    private void Jump()
    {
        body.linearVelocity = new Vector2(body.linearVelocity.x, speed);
        jumpCount++;
        grounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = true;
            jumpCount = 0;
        }
    }

    public void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}