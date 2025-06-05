using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageZone : MonoBehaviour
{
        [SerializeField] private AudioClip damageSound;

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null)
        {
            SoundManager.instance.PlaySound(damageSound);
            controller.ChangeHealth(-1);
            Restart();
        }
    }

      private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
