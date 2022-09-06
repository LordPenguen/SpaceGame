using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class DialougeManager : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject HTP;

    [SerializeField] private Dialouge dia;

    public TMP_Text textTalk;
    string mesText;
    public int i;

    [SerializeField] private GameObject[] Pics;
    public Transform viper;
    public Transform aimgun;
    public Transform enemy;

    public aimthing at;

    public Transform firepoint;
    public GameObject bulletPrefab;
    public float bulletForce = 1f;

    public bool backclicked;


    [SerializeField] private GameObject[] ammo;
    

    void Awake() {

        textTalk = transform.Find("talkPanel").Find("talk11").GetComponent<TMP_Text>();

        at.dir = 0;
    }

    public void Back(){

        MainMenu.gameObject.SetActive(true);
        HTP.gameObject.SetActive(false);

        backclicked = true;

        if(backclicked){
            HTPstart();
        }

        
    }

    public void nextText(){

        string[] talkArray = new string[]{
            "This is your ship, as the captain your job is to neutralize our enemies.",
            "You can only fire your middle gun, other guns are not ready... yet",
            "The Middle Gun rotates almost 180 degrees. So you need to aim good to shoot enemies.",
            "To launch the specially designed fireball you need to press 'space'.",
            "As you can see you have limited ammo. Crafting these fireballs aint easy.",
            "There are so many fleet types. They usually attack as 4 waves.",
            "Be carefull captain and good luck...Because you gonna need it."
        };

        

        if ( i < 7 )
        {
            mesText = talkArray[i];

            dia.AddWriter(textTalk, mesText, .05f ,true);
            Pics[i].gameObject.SetActive(true);
            
            i++;
            
        }  

        if(i==8) dia.AddWriter(textTalk,"Go to warzone, captain", .05f,true);

        

        TweeninObjects();
        
    }

    public void TweeninObjects(){

        float longy = -2f;
        float gun = -1.2f;
        float enemi = 3.5f;
    
        //viper
        viper.DOMoveY(longy,3f);

        //aim thing + fire
        if(i==2) aimgun.DOMoveY(gun,2f);

        if(i==3) {

            at.dir=20f;

            StartCoroutine(Stoppin());
        } 

        //ammo thing
        if(i==4){
            
            int j;
            for(j=0; j<4; j++){
            ammo[j].gameObject.SetActive(true);
            }

            StartCoroutine(Couple());
            
            ammo[0].gameObject.SetActive(false);
        }

        //enemi
        if(i==6){

            enemy.DOMoveY(enemi,3f);

            StartCoroutine(Couple());

            ammo[1].gameObject.SetActive(false);
            
        }
            
    }   

    IEnumerator Stoppin(){
        yield return new WaitForSeconds(4.4f);
        at.dir=0;
    }
     IEnumerator Couple(){
        yield return new WaitForSeconds(2f);
        shoot();
        }

    void shoot(){
        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);


    }

   public void HTPstart(){
         int j;
         //Pic array = 0
            for(j=0;j<=i;j++){
            Pics[j].gameObject.SetActive(false);
            }  
    }
    
    public void HTPEnd(){
    
         int k;
         //Pic array = 0
            for(k=0;k<=i;k++){
            Pics[k].gameObject.SetActive(true);
            }  

    }
   

    
}
