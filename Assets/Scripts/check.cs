using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour
{
    public GameOver gm;
    public int mama;


    public void checkin(){

        mama--;

        if(mama <=0){
            
            gm.enemyCheck = false;
            gm.NextLevel();
        }

      
    }


}
