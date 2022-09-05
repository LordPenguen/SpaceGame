using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viper : MonoBehaviour
{
    [SerializeField] ParticleSystem particle;

    public check ck;

    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.gameObject.tag=="enemy"){

        Instantiate(particle,transform.position,Quaternion.identity);
        Destroy(gameObject);

        ck.CheckAlive();
        }
        
    }

  

}  
