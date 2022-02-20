using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    public GameObject greenWall;
    public GameObject blueWall;
    public GameObject blueKeyImg;
    public GameObject greenKeyImg;
    public AudioSource pickup;

    private void Start()
    {
        blueKeyImg.SetActive(false);
        greenKeyImg.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)//Unlocks the coloured walls depending on the collided object
    {
        if (collision.gameObject.name == "Green Key")
        {
            pickup.Play();
            Destroy(greenWall);
            Destroy(collision.gameObject);
            greenKeyImg.SetActive(true);//Displays key image on UI
            Debug.Log("Green key picked up");
        }

        if (collision.gameObject.name == "Blue Key")
        {
            pickup.Play();
            Destroy(blueWall);
            Destroy(collision.gameObject);
            blueKeyImg.SetActive(true);
            Debug.Log("Green key picked up");
        }
    }
}
