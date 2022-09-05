using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HowToPlay : MonoBehaviour
{
   public GameObject playPanel;
   public GameObject HTPPanel;
   public GameObject BG;

   public DialougeManager DM;

   public void Unseeble(){

    playPanel.gameObject.SetActive(false);
   }

   public void OpenHTP(){

      HTPPanel.gameObject.SetActive(true);
      BG.gameObject.SetActive(false);
      DM.backclicked=false;
   }

  
}
