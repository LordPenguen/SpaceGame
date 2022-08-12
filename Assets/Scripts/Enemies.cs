using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;

public class Enemies : MonoBehaviour
{

  [SerializeField] ParticleSystem particle;
  public check ck;


  void OnCollisionEnter2D(Collision2D other) {

    Instantiate(particle,transform.position,Quaternion.identity);
    Destroy(gameObject);

    ck.checkin();

  }

  

  

    
}
