using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform firepoint;
    public GameObject bulletPrefab;

    public float bulletForce = 1f;
    
    
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Shoot();
        }
    }

    void Shoot(){

        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);

    }

      
}
