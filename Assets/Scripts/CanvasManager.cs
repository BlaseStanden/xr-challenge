using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public bool start = false;
    public bool quit = false;
    public bool howToPlay = false;
    public bool menu = false;
    public GameObject htpCanvas;
    public GameObject menuCanavs;
    
    void Start()
    {
        htpCanvas.SetActive(false);
    }

    public void MenuSwitch()//Assigns the menu switch via clicking on the button
    {
        if (start == true)
        {
            SceneManager.LoadScene("Main");
        }
        if (quit == true)//Closes the application
        {
            Debug.Log("Quit");
            Application.Quit();
        }
        if (howToPlay == true)
        {
            Debug.Log("HTP Switch");
            htpCanvas.SetActive(true);
            
        }
        if (menu == true)
        {
            Debug.Log("Menu Switch");
            htpCanvas.SetActive(false);
            menuCanavs.SetActive(true);
        }
    }
}
