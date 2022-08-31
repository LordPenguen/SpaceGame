using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StopMenu : MonoBehaviour
{
    public GameObject SMenu;

    //if presssed stop game
    //can mute sounds or open them maybe change the volume

    public void SeeMenu(){

        SMenu.gameObject.SetActive(true);

    }

    public void NotSeeMenu(){

        SMenu.gameObject.SetActive(false); 
    }


    public void MainMenu(){

        SceneManager.LoadScene(0);  
    }


}
