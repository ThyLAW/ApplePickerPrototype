using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]

    public Text scoreGT;

    public GameObject applePrefab;
    public float speed = 1.0f;
    public float[] speedArray = { -15 ,20, 25, 50, 51};
    public float leftAndRightEdge = 10f;
    public float leftAndRightEdgeBackup = 30f;
    public float chanceToChangeDirections = 1f;
    public float secondsBetweenAppleDrops = 1f;
    public float[] secondsBetweenAppleDropsDifficulty = { 2, 3, 4, 5, 6};
    public float difficulty1Reference;
    public float difficulty2Reference;
    public float difficulty3Reference;
    public float difficulty4Reference;
    public float difficulty5Reference;

    
    


    // Start is called before the first frame update
    void Start()
    {
       //dropping apples every second 
       Invoke("DropApple", 2f);
        // gets the score
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreGT = scoreGO.GetComponent<Text>();

        difficulty1Reference = Difficulty.getDifficulty1();

        difficulty2Reference = Difficulty.getDifficulty2();

        difficulty3Reference = Difficulty.getDifficulty3();

        difficulty4Reference = Difficulty.getDifficulty4();

        difficulty5Reference = Difficulty.getDifficulty5();


    }

    void DropApple(){
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", secondsBetweenAppleDrops);
    }

    // Update is called once per frame
    void Update()
    {
        //basic movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        //changing direction

        if (pos.x <= - leftAndRightEdge){
            speed = Mathf.Abs(speed);

        }
        else if (pos.x >= leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }

        if (pos.x <= -leftAndRightEdgeBackup)
        {
            speed = Mathf.Abs(speed);

        }
        else if (pos.x >= leftAndRightEdgeBackup)
        {
            speed = -Mathf.Abs(speed);
        }
        else if (Random.value < chanceToChangeDirections){
            speed *= -1;
        }

        //gets the score, changes speed based on score for difficulty
        int score = int.Parse(scoreGT.text);
        if (score == difficulty1Reference)
        {
            speed = 0; 
            speed += speedArray[0];

            secondsBetweenAppleDrops = secondsBetweenAppleDropsDifficulty[0];
            

        }
        else if (score == difficulty2Reference)
        {
            speed = 0;
            speed = speedArray[1];

            secondsBetweenAppleDrops = secondsBetweenAppleDropsDifficulty[1];
            

        }
        else if (score == difficulty3Reference)
        {
            speed = 0;
            speed = speedArray[2];

            secondsBetweenAppleDrops = secondsBetweenAppleDropsDifficulty[2];

        }
        else if (score == difficulty4Reference)
        {
            speed = 0;
            speed = speedArray[3];

            secondsBetweenAppleDrops = secondsBetweenAppleDropsDifficulty[3];

        }
        else if (score == difficulty5Reference)
        {
            speed = 0;
            speed = speedArray[4];

            secondsBetweenAppleDrops = secondsBetweenAppleDropsDifficulty[4];

        }
        

    }


}



