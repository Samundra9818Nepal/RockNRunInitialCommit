using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;


public class Scores : MonoBehaviour
{

    public int currentScore;
    public int multiplier;
    public int notes;

    public int [] filescore;

    public string[] score;
    string paths = "Assets/HighScores.txt";

    public int currentLevel;
    string storeText;
    

    // Start is called before the first frame update
    void Start()
    {
        multiplier = 1;
        Read();
        
    }

    // Update is called once per frame
    void Update()
    {


    }
    // compares the saved score agianst the currentscore
    void GetHighScore()
    {
        Read();

        if (currentScore > filescore[currentLevel])
        {
            NewHeighScore();

            filescore[currentLevel] = currentScore;
        }

       

    }
    // saves the current score into the text file
    void NewHeighScore()
    {
        StreamWriter sw = new StreamWriter(paths);

        //string storeText = currentScore.ToString();
        for (int i = 0; i < 3; i++)
        {
            if (i == currentLevel)
            {
                filescore[currentLevel] = currentScore;

            }
            
            storeText += (filescore[i].ToString() + ("/n"));
        }

        sw.WriteLine(storeText);

        sw.Close();
    }

    void Read()
    {
        String path = paths;
        StreamReader reader = new StreamReader(path);
        string loadScore = reader.ReadLine();
       
        string[] score = loadScore.Split("/n"[0]);
        
        for (int i = 0; i < 3; i++)
        {
            filescore [i] = int.Parse(score[i]);

        }
       
        
        reader.Close();

    }

    public void CalScore()
    {
        currentScore = currentScore + (1 * multiplier);
    }

    public void Notes()
    {
        notes++;
        if (notes % 4 == 0)
        {

            if (multiplier < 4)
            {
                multiplier++;
            }

        }

    }
    public void HitOb()
    {
        multiplier = 1;
        notes = 0;
    }
}
