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

    public GameObject winText;

    public AudioSource itemBeep;

    public float timeDelay = 5f;

    int score;

    private void Start()//Sets the current game objects to inactive on load
    {
        endBlock.SetActive(false);
        winText.SetActive(false);

    }

    void OnCollisionEnter(Collision collision)
    {        
        if (collision.gameObject.name == "Pickup") //Checks if player collided with pickup
        {
            int scr = collision.gameObject.GetComponent<Pickup>().GetPickedUp();//Uses pickup class to assign the score
            score += scr;//Adds the score to a new int variable           
            itemBeep.Play();
            Debug.Log("Current Score <color=yellow> : " + score + "</color>");
            Destroy(collision.gameObject);//Destroys the collided game object
            Debug.Log(collision.gameObject.name + " is destroyed");                   
        }
        if (score >= 500)//If the score is the same or more than this value it adds the UI elements and sets the end block active and visible
        {
            endBlock.SetActive(true);
            winText.SetActive(true);
            Debug.Log("You win");
        }
        if (collision.gameObject.name == "End Block")//Once the player collides with the end block, it will send the player to the end scene
        {
            SceneManager.LoadScene("End");
            Debug.Log("You Escaped");
        }
    }

    public int ScoreReturn()
    {
       return score;
    }

    void Update()
    {
        scoreText.text = "SCORE: " + score.ToString(); //Updates the UI element to score of the player
    }
}
