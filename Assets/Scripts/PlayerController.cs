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

    void Start()
    {
        MoveAction.Enable();
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move = MoveAction.ReadValue<Vector2>();

        CheckIfGrounded();
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded) {
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
}