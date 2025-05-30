using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction MoveAction;

    private Rigidbody2D rigidbody2d;
    private Vector2 move;

    [Header("Movement Settings")]
    public float speed = 3.0f;

    [Header("Jump Settings")]
    public float jumpForce = 10f;
    public LayerMask groundLayer;
    public Transform groundCheck;
    public float groundCheckRadius = 0.1f;
    private bool isGrounded;

    private GameObject portal;

    void Start()
    {
        MoveAction.Enable();
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move = MoveAction.ReadValue<Vector2>();

        CheckIfGrounded();
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            Jump();
        }
    }

    void CheckIfGrounded()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
    }

    void Jump()
    {
        rigidbody2d.linearVelocity = new Vector2(rigidbody2d.linearVelocity.x, jumpForce);
    }

    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position + new Vector2(move.x, 0) * speed * Time.fixedDeltaTime;
        rigidbody2d.MovePosition(position);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    private void LevelTransition()
    {
        if ((SceneManager.GetActiveScene().name == "Level1") && collision.gameObject.CompareTag("Portal"))
        {
            SceneManager.LoadScene("Level_2");
        }
        else ((SceneManager.GetActiveScene().name == "Level2") && collision.gameObject.CompareTag("Portal"))
        {
            SceneManager.LoadScene("Level_3");
        }
        else ((SceneManager.GetActiveScene().name == "Level3") && collision.gameObject.CompareTag("Portal"))
        {
            SceneManager.LoadScene("Level_4");
        }
        else ((SceneManager.GetActiveScene().name == "Level4") && collision.gameObject.CompareTag("Portal"))
        {
            SceneManager.LoadScene("Epilogue");
        }
    }

   // private void EpilogueEnd()
   // {
    //    if (SceneManager.GetActiveScene().name == "Epilogue")
     //       SceneManager.LoadScene("");
  //  }

}
