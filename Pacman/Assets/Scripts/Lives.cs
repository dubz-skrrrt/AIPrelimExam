﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Lives : MonoBehaviour
{
    // Start is called before the first frame update
    public int Life = 3;
    public Text healhtext;
    // Update is called once per frame
    void Update()
    {
        var lives = GameObject.FindGameObjectWithTag("Lives");
        Debug.Log(Life);
        if (Life != 0){
            DontDestroyOnLoad(lives);
        }else{
            Destroy(lives);
        }
        healhtext = GameObject.FindGameObjectWithTag("HealthText").GetComponent<Text>();
        ChangeText();
        
    }

    void ChangeText(){
        healhtext.text = "LIVES: " + GameObject.FindGameObjectWithTag("Lives").GetComponent<Lives>().Life;
    }
}
