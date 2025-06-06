using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D body;
    //movement
    [SerializeField] private float speed;
    private bool grounded;
    private int jumpCount = 0;
    private int maxJumps = 2;
    private int shrinkCount = 0;
    private Vector2 movementInput;

    //health
    public int maxHealth = 10;
    int currentHealth;
    public int health { get { return currentHealth; } }
    //audio
    [SerializeField] private AudioClip jumpSound;
    [SerializeField] private AudioClip shrinkSound;
    //winning
    [SerializeField] private AudioClip winSound;



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
        float horizontalInput = Input.GetAxis("Horizontal");
        body.linearVelocity = new Vector2(horizontalInput * speed, body.linearVelocity.y);
        if (horizontalInput > 0f)
            transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
        else if (horizontalInput < 0f)
            transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);



        Gamepad gamepad = Gamepad.current;


        if (gamepad == null) return;


        if (gamepad.buttonWest.wasPressedThisFrame && grounded)
        {
            Debug.Log("X button pressed");
            Shrink();
        }


        if (gamepad.buttonNorth.wasPressedThisFrame && jumpCount < maxJumps)
        {
            Debug.Log("Y button pressed");
            Jump();
        }
        


    }

    private void Jump()
    {
        SoundManager.instance.PlaySound(jumpSound);
        body.linearVelocity = new Vector2(body.linearVelocity.x, speed);
        jumpCount++;
        grounded = false;
    }

    private void Shrink()
    {
        SoundManager.instance.PlaySound(shrinkSound);
        if(shrinkCount % 2 == 0)
        {
            transform.localScale = new Vector2(1.0f, 1.0f);
        }
        else
        {
            transform.localScale = new Vector2(0.5f, 0.5f);
        }
        shrinkCount++;
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
        UIHandler.instance.SetHealthValue(currentHealth / (float)maxHealth);
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("LevelUp"))
        {
            LevelTransition(other);
        }
    }


    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    private void LevelTransition(Collider2D portal)
    {
        if (portal.name == "Level1Portal")
        {
            SceneManager.LoadScene("Level2");

        }
        else if (portal.name == "Level2_portal")
        {
            SceneManager.LoadScene("Level3");

        }
        else if (portal.name == "Level3_portal_0")
        {
            SceneManager.LoadScene("Level4");
        }
        else if (portal.name == "Level4_portal")
        {
            //text display saying you won
        }
    }

}