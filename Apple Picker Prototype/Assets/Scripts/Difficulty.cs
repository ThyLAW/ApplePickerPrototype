using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Difficulty : MonoBehaviour
{
    public Text scoreGT;
    public static int difficulty1 = 1000;
    public static int difficulty2 = 2000;

    public static int difficulty3 = 3000;

    public static int difficulty4 = 5000;

    public static int difficulty5 = 10000;


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
        if (score == getDifficulty2())
        {
            setDifficulty(2);
        }
          if (score == getDifficulty3())
        {
            setDifficulty(3);
        }
          if (score == getDifficulty4())
        {
            setDifficulty(4);
        }
          if (score == getDifficulty5())
        {
            setDifficulty(5);
        }
    }

    //sets ui difficulty
    public void setDifficulty(int difficultyInput)
    {
        Text Difficulty = this.GetComponent<Text>();
        Difficulty.text = "Difficulty " + difficultyInput;
        if(difficultyInput == 1){
            Difficulty.color = Color.cyan;
        }
        else if(difficultyInput == 2){
            Difficulty.color = Color.magenta;
        }
          else if(difficultyInput == 3){
            Difficulty.color = Color.yellow;
        }
          else if(difficultyInput == 4){
            Difficulty.color = Color.white;
        }
          else if(difficultyInput == 5){
            Difficulty.color = Color.red;
        }

    }

    //gets difficulties
    public static int getDifficulty1()
    {
        return difficulty1;
    }
    public static int getDifficulty2()
    {
        return difficulty2;
    }
    public static int getDifficulty3()
    {
        return difficulty3;
    }
    public static int getDifficulty4()
    {
        return difficulty4;
    }
    public static int getDifficulty5()
    {
        return difficulty5;
    }

}
