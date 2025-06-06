using UnityEngine;

public class FinalBossController : MonoBehaviour
{
    private AudioClip dangerSound;
    private float volume = 0.3f;

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null)
        {
            SoundManager.instance.PlaySound(dangerSound, volume);
            Destroy(gameObject);
        }
    }
}
