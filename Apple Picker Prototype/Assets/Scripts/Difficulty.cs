using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Difficulty : MonoBehaviour
{
    public Text scoreGT;
    public static int difficulty1 = 1000;

    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreGT = scoreGO.GetComponent<Text>();

        
    }

    // Update is called once per frame
    void Update()
    {
        int score = int.Parse(scoreGT.text);
        if(score == getDifficulty1())
        {
            setDifficulty(1);
        }
        if (score == 2500)
        {
            setDifficulty(2);
        }
    }

    public void setDifficulty(int difficultyInput)
    {
        Text Difficulty = this.GetComponent<Text>();
        Difficulty.text = "Difficulty " + difficultyInput;

    }


    public int getDifficulty1()
    {
        return difficulty1;
    }
}
