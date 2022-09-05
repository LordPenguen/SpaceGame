using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StopMenu : MonoBehaviour
{
    public GameObject SMenu;
    private bool gamePaused;

    //if presssed stop game
    //can mute sounds or open them maybe change the volume

    public void SeeMenu(){

        SMenu.gameObject.SetActive(true);
        Time.timeScale = 0f;
        gamePaused=true;

    }

    public void NotSeeMenu(){
        
        Time.timeScale = 1f;
        gamePaused=false;
        SMenu.gameObject.SetActive(false); 
    }


    public void MainMenu(){

        SceneManager.LoadScene(0);  
        Time.timeScale = 1f;
    }

    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            if(gamePaused) NotSeeMenu();
            else SeeMenu();
        }
    }


}
