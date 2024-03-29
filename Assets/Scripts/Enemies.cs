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

    if(other.gameObject.tag =="bullet"){

    Instantiate(particle,transform.position,Quaternion.identity);
    Destroy(gameObject);

    ck.checkin();
    }
   

  }

  void EnemyMove(){

    if(Vector2.Distance(transform.position, points[i].position) < 0.02f){

        i++;

        if(i==points.Length){

          i=0;
        }
      }

      transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);

  }
 

  void Update() {

    if(enemy==2) EnemyMove();
   
    
  }

  

  

    
}
