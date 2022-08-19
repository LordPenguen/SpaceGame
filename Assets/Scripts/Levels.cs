using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Levels : MonoBehaviour
{
    public GameObject playPanel;
    public GameObject levelPanel;
    public GameObject MenuPanel;

    int levelsUnlocked;

    public Button[] buttons;

    public void Start(){

        levelsUnlocked = PlayerPrefs.GetInt("levelsUnlocked",1);

        //level tuşlarını kapama şeysi
        for (int i = 0; i < buttons.Length; i++)
        {
            if(i+1 >levelsUnlocked)
                buttons[i].interactable=false;
        }

    }


    public void Unseeble(){

    playPanel.gameObject.SetActive(false);

   }

   public void chooseLevel(){

    MenuPanel.gameObject.SetActive(false);
    levelPanel.gameObject.SetActive(true);

   }

   public void ChangeLevel(int levelIndex){

    SceneManager.LoadScene(levelIndex);
    
   }

}
