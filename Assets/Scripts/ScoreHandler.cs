using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreHandler : MonoBehaviour
{
    public int displayScore;
    //public TMP_Text scoreText;
    public int score;
    

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        ScoreDisplay();
    }

    void Update()
    {        
        displayScore += score;

        Debug.Log("Score: " + score);
        Debug.Log("Display Score: " + displayScore);
        //scoreText.text = "SCORE: " + displayScore.ToString();
    }

    public int ScoreDisplay()
    {
        score = gameObject.GetComponent<ScoreController>().ScoreReturn();

        return displayScore;
    }


}
