using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
    public GameObject GOS;
    public GameObject GOS2;
    public bool ammoCheck = false;
    public bool enemyCheck = true;
    int currentLevel;

    public check ck;
    public aimthing at;

    public Animator Anim;

    private AudioClip ExpSound;
    public AudioSource audioSource;


    private void Start() {

        ExpSound = (AudioClip)Resources.Load("exp1");

    }


    //unlocks next level
   public void NextLevel(){

        currentLevel = SceneManager.GetActiveScene().buildIndex;

        if(currentLevel <= PlayerPrefs.GetInt("levelsUnlocked")){

            PlayerPrefs.SetInt("levelsUnlocked", currentLevel+1);

            StartCoroutine(NextScene());
        }

        //if last level(scene16) play credits
        if(currentLevel==16) StartCoroutine(NextScene());
 

    }


    //if enemy hits u screeen
    public void GameEnd(){

        audioSource.clip = ExpSound;
        audioSource.Play();

        if(ammoCheck) GOS2.gameObject.SetActive(false);
        else GOS2.gameObject.SetActive(true);
        

    }

    //Text Can change depending how u ended? -Out of ammo -Enemis killed u?
    //if out of ammo & enemis alive GameOverScreen becomes visible
   public IEnumerator EndGame(){ 

        yield return new WaitForSeconds(.5f);

        if(ammoCheck && enemyCheck){

            GOS.gameObject.SetActive(true);    
           // ck.SpeedZero();
           at.dir=0f;
        }

    }

     public IEnumerator NextScene(){ 

        Anim.SetTrigger("StartAnim");

        yield return new WaitForSeconds(.5f); 

        SceneManager.LoadScene(currentLevel+1);
        
    }
}
