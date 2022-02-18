using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public bool start = false;
    public bool quit = false;

    public void MenuSwitch()
    {
        if (start == true)
        {
            SceneManager.LoadScene("Main");
        }
        if (quit == true)
        {
            Application.Quit();
        }
    }
}
