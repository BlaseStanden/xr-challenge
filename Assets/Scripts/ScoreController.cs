using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    public GameObject star;

    public TMP_Text scoreText;

    public GameObject endBlock;



    int score;

    private void Start()
    {
        endBlock.SetActive(false);
    }

    void OnCollisionEnter(Collision collision)
    {        
        if (collision.gameObject.name == "Pickup")
        {
            int scr = collision.gameObject.GetComponent<Pickup>().GetPickedUp();
            score += scr;           
            Debug.Log("Current Score <color=yellow> : " + score + "</color>");
            Destroy(collision.gameObject);
            Debug.Log(collision.gameObject.name + " is destroyed");
        }
        if (score == 100)
        {
            endBlock.SetActive(true);
            Debug.Log("You win");
        }
        if (collision.gameObject.name == "End Block")
        {
            SceneManager.LoadScene("End");
            Debug.Log("You Escaped");
        }
    }

    void Update()
    {
        scoreText.text = "SCORE: " + score.ToString();
    }

}
