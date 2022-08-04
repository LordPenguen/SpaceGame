using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform firepoint;
    public GameObject bulletPrefab;

    [SerializeField] private GameObject[] ammo;

    private int counter=0;

    public float bulletForce = 1f;

    void Start() {

        for(int i=0; i<4; i++){

            ammo[i].gameObject.SetActive(true);
        }
        
    }
    
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Shoot();
        }
    }

    void Shoot(){

        if(counter<4){

        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);

        ammo[counter].gameObject.SetActive(false);
        counter++;
        }

    }
      
}
