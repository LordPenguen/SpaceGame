using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aimthing : MonoBehaviour
{
    public float dir = 20f;
    private Vector3 thing;
    public GameObject rotationCenter;

    public Vector2 aim;
    public Vector2 point;
    public Vector2 point2;
    public float angle = 0;
    public float angle2 = 0;

    public int counter = 0;

    void Awake() {
       
    }


    void Update()
    {  
        //Makes it rotate around our spaceship
        transform.RotateAround(rotationCenter.transform.position, Vector3.forward, dir*Time.deltaTime);

        //Checks Right and Left points, if on point changes direction
        aim = new Vector2(transform.position.x, transform.position.y);
        angle = Vector2.Angle(point,aim);
        angle2 = Vector2.Angle(point2,aim); 

        if(angle <= 0f) dir = dir * (-1);
        if(angle2 <= 0f) dir = dir * (-1);

        //Debug.Log(aim);

        //If pressed space stop & count bullets
        if(Input.GetButtonDown("Jump")){
            counter++;
        }
        
     
    }

  

    
}
