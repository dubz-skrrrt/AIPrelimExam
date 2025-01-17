﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Lives : MonoBehaviour
{
    // Start is called before the first frame update
    public int Life = 3;
    public Text healthtext;
    // Update is called once per frame
    void Update()
    {
        var lives = GameObject.FindGameObjectWithTag("Lives");
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerSystem>().complete == true){
            Destroy(lives);
        }else if (Life != 0){
            DontDestroyOnLoad(lives);
        }else{
            Destroy(lives);
        }
        healthtext = GameObject.FindGameObjectWithTag("HealthText").GetComponent<Text>();
        ChangeText();
        
    }

    void ChangeText(){
        
        healthtext.text = "LIVES: " + GameObject.FindGameObjectWithTag("Lives").GetComponent<Lives>().Life;
    }
}
