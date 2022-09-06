using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour
{
    public GameOver gm;
    public int mama;

    public Viper viper;
    public bool Udead=false;

    public Enemies enemy;

    private AudioClip ExpSound;
    public AudioSource audioSource;


    private void Start() {

        ExpSound = (AudioClip)Resources.Load("exp2");

    }

    public void checkin(){

        mama--;

        audioSource.clip = ExpSound;
        audioSource.Play();

        if(mama <=0){
            
            gm.enemyCheck = false;
            gm.NextLevel();
        }
      
    }

    public void CheckAlive(){

        Udead=true;

        if(Udead){
            gm.GameEnd();
            SpeedZero();
        }
    }


    public void SpeedZero(){
        enemy.speed=0;
    }




}
