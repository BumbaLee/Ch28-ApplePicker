﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    static public int score=1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake(){
        //If the PlayerPrefs HighScore already exists, read it
        if(PlayerPrefs.HasKey("HighScore")){
            score=PlayerPrefs.GetInt("HighScore");
        }
        //Assign the high score to HighScore
        PlayerPrefs.SetInt("HighScore",score);
    }

    // Update is called once per frame
    void Update()
    {
        Text gt= this.GetComponent<Text>();
        gt.text= "High Score: "+score; 
        //Update the PlayerPrefs HighScore if nexessary
        if(score>PlayerPrefs.GetInt("HighScore")){
            PlayerPrefs.SetInt("HighScore",score);
        }
    }
}
