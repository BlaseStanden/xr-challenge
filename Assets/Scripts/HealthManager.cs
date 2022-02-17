using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class HealthManager : MonoBehaviour
{
    public int healthPoints = 100;

    public TMP_Text healthText;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Enemy")
        {
            healthPoints -= 20;         

            Debug.Log("Damage Taken. " + healthPoints + " HP left.");

            if (healthPoints <= 0)
            {
                Debug.Log("You are dead");
            }
        }
    }

    void Update()
    {
        healthText.text = "HP: " + healthPoints.ToString();

        if (healthPoints <= 0)
        {
            healthText.text = "DEAD";
        }
    }
}
