using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject GOS;
    public bool ammoCheck = false;
    public bool enemyCheck = true;


    //unlocks next level
   public void NextLevel(){

        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if(currentLevel >= PlayerPrefs.GetInt("levelsUnlocked")){

            PlayerPrefs.SetInt("levelsUnlocked", currentLevel+1);

            SceneManager.LoadScene(currentLevel+1);
        }

        Debug.Log("levl"+PlayerPrefs.GetInt("levelsUnlocked")+"unlckd");

    }

    //Text Can change depending how u ended? -Out of ammo -Enemis killed u?
    //if out of ammo & enemis alive GameOverScreen becomes visible
   public void EndGame(){

        if(ammoCheck && enemyCheck){
            
            GOS.gameObject.SetActive(true);
        }

    }
}
