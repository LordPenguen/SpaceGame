using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;

public class Enemies : MonoBehaviour
{

  [SerializeField] ParticleSystem particle;
  public check ck;
  public int enemy;

  public int startingPoint;
  public float speed;
  public Transform[] points;
  int i=0;


  void OnCollisionEnter2D(Collision2D other) {

    Instantiate(particle,transform.position,Quaternion.identity);
    Destroy(gameObject);

    ck.checkin();

  }

  void EnemyType2(){


  }
  

  void Update() {

    if(enemy == 2){

      if(Vector2.Distance(transform.position, points[i].position) < 0.02f){

        i++;

        if(i==points.Length){

          i=0;
        }
      }

      transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);

    }
    
  }

  

  

    
}
