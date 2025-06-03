using UnityEngine;

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
        }
    }
}
