using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class HealthManager : MonoBehaviour
{
    public int healthPoints = 100;

    public TMP_Text healthText;

    public GameObject deathText;

    public GameObject endTimer;

    public AudioSource damage;
    public AudioSource dead;

    void Start()
    {
        deathText.SetActive(false);
        endTimer.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Enemy")
        {
            healthPoints -= 20;//Removes health on collision         
            damage.Play();
            Debug.Log("Damage Taken. " + healthPoints + " HP left.");

            if (healthPoints <= 0)
            {
                endTimer.SetActive(true);//Sets off the end timer before reloading the scene
                deathText.SetActive(true);//Displays death text
                Debug.Log("You are dead");
            }
        }
    }

    void Update()
    {
        healthText.text = "HP: " + healthPoints.ToString();

        if (healthPoints <= 0)
        {
            dead.Play();
            Destroy(gameObject);
            healthText.text = "DEAD";
        }
    }
}
