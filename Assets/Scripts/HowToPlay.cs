using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HowToPlay : MonoBehaviour
{
   public GameObject playPanel;

   public void Unseeble(){

    playPanel.gameObject.SetActive(false);
   }

}
