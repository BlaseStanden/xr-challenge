using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public GameObject star;
    public Text scoreText;
  
    public static int score;

    //public AudioSource pickUpSound;

    Pickup pickup;




    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Pickup")
        {
            score += 1;

            //pickup.GetPickedUp();

            Debug.Log("Current Score <color=yellow> : " + score + "</color>");

            Destroy(collision.gameObject);
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log(gameObject.name + " is destroyed");
        }
    }


    //void OnTriggerEnter(Collider collider)
    //{
    //    score += 1;

    //    Debug.Log("Current Score <color=yellow> : " + score + "</color>");



    //}


    //void Update()
    //{
    //    scoreText.GetComponent<Text>().text = "Score: " + score;
    //}


}
