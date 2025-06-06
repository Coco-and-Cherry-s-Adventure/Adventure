using UnityEngine;
using UnityEngine.SceneManagement;

public class TntController : MonoBehaviour
{
    
     [SerializeField] private AudioClip damageSound;

    private AudioSource source;
    public AudioClip explosion9;

    private Rigidbody2D body;

    private GameObject Tnt;
    private GameObject explosion;   
    private GameObject floatingTnt;
   
   


    void Start()
    {

        body = GetComponent<Rigidbody2D>(); 
        Tnt = transform.Find("Tnt").gameObject;
        explosion = transform.Find("explosion").gameObject;
        floatingTnt = transform.Find("FloatingTnt").gameObject;
        source = GetComponent<AudioSource>();
    }

      public void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();
         if (other.gameObject.CompareTag("Player"))
        {
       
         if (controller != null)
            {
            float distance = Vector2.Distance(transform.position, other.transform.position);

            if (distance < 6.0f)
            {
            controller.ChangeHealth(-1);
            Explode(explosion);
            Restart();
            }
    }
}

    }


    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Explode(GameObject explosion)
    {
        explosion.SetActive(true);
        //explosion.transform.position = Tnt.transform.position;
        source.PlayOneShot(explosion9);
        Destroy(explosion, 1.0f);

    }



    


}
