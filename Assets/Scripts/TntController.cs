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
        Tnt = gameObject;
        explosion = transform.Find("Explosion").gameObject;
        floatingTnt.SetActive(true);
        source = GetComponent<AudioSource>();
    }

      public void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null)
        {
            controller.ChangeHealth(-1);
            Explode(explosion);
            Respawn();
        }
    }


    private void Respawn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //rest of the implementation
    }

    private void Explode(GameObject explosion)
    {
        explosion.SetActive(true);
        source.PlayOneShot(explosion9);
        Destroy(explosion);

    }


   // private OnTriggerEnter2D(Collider2D other)
   // {
    //    if (other.gameObject.CompareTag("Player"))
    //    {
    //        if (controller != null )//&& other.GameObject.CompareTag("Player").)
     //       {
                
   //             controller.ChangeHealth(-1);
   //             Explode(explosion);
    //            Respawn();
   //         }
        //}
  //  }
}
