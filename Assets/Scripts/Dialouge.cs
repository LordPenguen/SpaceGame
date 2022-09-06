using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialouge : MonoBehaviour
{

    private TMP_Text spaceText;
    private int charIndex;
    private string textToWrite;
    private float timePerChar;
    private float timer;
    private bool invisibleChar;

    [SerializeField] private DialougeManager diaMan;

    public bool pengu;
    public GameObject Peng;


    public void AddWriter(TMP_Text spaceText, string textToWrite, float timePerChar, bool invisibleChar ){

        this.spaceText = spaceText;
        this.textToWrite = textToWrite;
        this.timePerChar = timePerChar;
        this.invisibleChar = invisibleChar;
        charIndex = 0;
    }

    
    void Update() {

        //If pressed space next text
        
        if(Input.GetButtonDown("Jump"))
        {
           diaMan.nextText();

        } 
        
        //meep meep writing
        if(spaceText != null){

            timer -= Time.deltaTime;

            while(timer <=0f){

                timer += timePerChar;
                charIndex++;
                string text = textToWrite.Substring(0,charIndex);

                if(invisibleChar){
                    text += "<color=#00000000>" + textToWrite.Substring(charIndex) + "</color>";

                    if(pengu){
                        Peng.gameObject.SetActive(true);
                        pengu=false;
                    }
                    else{
                        Peng.gameObject.SetActive(false);
                        StartCoroutine(PenguinTalk());
                    }
                }
                spaceText.text = text;

                //evrything display
                if(charIndex >= textToWrite.Length){
                    spaceText = null;
                    return;
                }



            } 

        
        }
        
    }

    public IEnumerator PenguinTalk(){ 

        yield return new WaitForSeconds(.3f);

        pengu=true;
        
    }

    
}
