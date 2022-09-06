using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{ 
    public GameObject GameSelect;
    private int presentLevel;


    public void Seeable(){

        GameSelect.gameObject.SetActive(true);
    }


    public void OpenScene(){

        SceneManager.LoadScene(1);
    }

    public void NewGame(){

        PlayerPrefs.SetInt("levelsUnlocked",1);
    }

    public void ContinueGame(){

        int GoToLevel = PlayerPrefs.GetInt("LastPlayedLevel");

        SceneManager.LoadScene(GoToLevel);
        
    }

    public void ContinueLevel(){

        presentLevel = SceneManager.GetActiveScene().buildIndex;

        PlayerPrefs.SetInt("LastPlayedLevel",presentLevel);

        SceneManager.LoadScene(presentLevel);
    }

    public void GoToMainmenu(){

        SceneManager.LoadScene(0);
    }
    
    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }

    public void SecretCredits(){

        int Secret = PlayerPrefs.GetInt("levelsUnlocked");

        if(Secret==17){
            SceneManager.LoadScene(17);
        }
    }

    
}
