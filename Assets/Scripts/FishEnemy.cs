using UnityEngine;
using UnityEngine.SceneManagement;

public class FishEnemy : MonoBehaviour
{
    [Header("Patrol Settings")]
    [SerializeField] private Transform leftEdge;
    [SerializeField] private Transform rightEdge;
    [SerializeField] private float speed = 2f;

    private bool movingLeft = true;
    private Vector3 initialScale;

    private void Start()
    {
        initialScale = transform.localScale;
    }

    private void Update()
    {
        if (movingLeft)
        {
            if (transform.position.x > leftEdge.position.x)
                Move(-1);
            else
                movingLeft = false;
        }
        else
        {
            if (transform.position.x < rightEdge.position.x)
                Move(1);
            else
                movingLeft = true;
        }
    }

    private void Move(int direction)
    {
        transform.localScale = new Vector3(Mathf.Abs(initialScale.x) * direction, initialScale.y, initialScale.z);
        transform.position += new Vector3(direction * speed * Time.deltaTime, 0f, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Restart level
        }
    }
}
