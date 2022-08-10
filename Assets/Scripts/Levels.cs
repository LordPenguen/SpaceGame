using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Levels : MonoBehaviour
{

    public GameObject camera;
    public Vector3 down;


    void Start()
    {
    
        
    }

    public void Slide(){

        Vector3 desiredPosition = camera.transform.position + down;

        camera.transform.position = desiredPosition;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
