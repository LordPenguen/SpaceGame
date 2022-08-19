using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialougeManager : MonoBehaviour
{

    [SerializeField] private Dialouge dia;

    public TMP_Text textTalk;
    string mesText;
    int i;


    void Awake() {

        textTalk = transform.Find("talkPanel").Find("talk11").GetComponent<TMP_Text>();

    }

    public void nextText(){

        string[] talkArray = new string[]{
            "This is your ship, as the captain your job is to neutralize our enemies.",
            "To launch the specially designed fireball you need to press 'space'.",
            "As you can see you have limited ammo. Crafting these fireballs aint easy.",
            "There are so mant fleet types. They usually attack as 4 waves.",
            "Be carefull captain and good luck...cuz you gonna need it."
        };

        if ( i <= 4 )
        {
            mesText = talkArray[i];

            dia.AddWriter(textTalk, mesText, .1f ,true);
            i++;
        }  
        
    }
    

    
}
