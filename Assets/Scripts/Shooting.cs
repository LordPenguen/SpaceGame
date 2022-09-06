using UnityEngine;
using UnityEngine.Audio;


public class Shooting : MonoBehaviour
{

    public Transform firepoint;
    public GameObject bulletPrefab;
    public GameOver GM;
    

    [SerializeField] private GameObject[] ammo;

    public int counter=0;

    public float bulletForce = 1f;

    private AudioClip bulletSound;
    public AudioSource audioSource;

    void Start() {
        //uı için dönen ammo lar
        for(int i=0; i<4; i++){

        ammo[i].gameObject.SetActive(true);
        } 

        bulletSound = (AudioClip)Resources.Load("laser2");
    }
    
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Shoot();
            
        }
    }

    void Shoot(){

        //shooting & counting ammos
        if(counter<4){

        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);

        ammo[counter].gameObject.SetActive(false);
        counter++;

        audioSource.clip=bulletSound;
        audioSource.Play();
        }

        //out of ammo ++bir tane variable true yap
        if(counter==4) { 

        GM.ammoCheck = true;
        StartCoroutine(GM.EndGame());
        }

    }


    
      
}
