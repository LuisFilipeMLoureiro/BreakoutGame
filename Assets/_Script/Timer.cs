using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{

    
    public Text currentTimeText;
    
    GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        //currentTime = 0;
        gm = GameManager.GetInstance();
        
    }

    // Update is called once per frame
    void Update()
    {
         if (gm.gameState == GameManager.GameState.GAME){
            gm.currentTime = gm.currentTime + Time.deltaTime;
             
         }

         TimeSpan time = TimeSpan.FromSeconds(gm.currentTime);
         currentTimeText.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
        
    }
}
