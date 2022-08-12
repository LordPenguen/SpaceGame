using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public bool Udead= false;


    void Update()
    {
        if(Udead) return;

        //if ammo=0 -> Udead=true

        //if enemies are dead -> next level
        
    }

   public void NextLevel(){

        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if(currentLevel >= PlayerPrefs.GetInt("levelsUnlocked")){

            PlayerPrefs.SetInt("levelsUnlocked", currentLevel+1);
        }

        Debug.Log("levl"+PlayerPrefs.GetInt("levelsUnlocked")+"unlckd");

    }


   public void EndGame(){

        Udead = true;

        Debug.Log("ım o n the next levll");

    }
}
