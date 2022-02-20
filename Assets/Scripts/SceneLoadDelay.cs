using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadDelay : MonoBehaviour
{

    public float timeDelay = 5f;

    private float timeElapsed;
        

    private void Update()//Gives a timed delay depending on the assigened float value
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > timeDelay)
        {
            SceneManager.LoadScene("End");//Loads the end scene
        }
    }
}
