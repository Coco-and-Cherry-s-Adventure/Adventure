using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    [SerializeField] private AudioClip pickUpSound;
    [SerializeField] private float volume = 0.3f;

    public void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null)
        {
            SoundManager.instance.PlaySound(pickUpSound, volume);
            controller.ChangeHealth(1);
            Destroy(gameObject);
        }
    }
}
