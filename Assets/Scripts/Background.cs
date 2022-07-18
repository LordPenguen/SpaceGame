using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    void Update()
    {
        transform.position += new Vector3(0,-2f*Time.deltaTime);

        if(transform.position.y< -10.8){
            
            transform.position = new Vector3(transform.position.x,10.8f);
        }

       

    }
}
