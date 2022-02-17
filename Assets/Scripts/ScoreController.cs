using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public GameObject star;

    public TMP_Text scoreText;
  
    public static int score;

    void OnCollisionEnter(Collision collision)
    {        
        if (collision.gameObject.name == "Pickup")
        {
            score += 1;           
            Debug.Log("Current Score <color=yellow> : " + score + "</color>");
            Destroy(collision.gameObject);
            Debug.Log(gameObject.name + " is destroyed");
        }
    }

    void Update()
    {
        scoreText.text = "SCORE: " + score.ToString();
    }

}
