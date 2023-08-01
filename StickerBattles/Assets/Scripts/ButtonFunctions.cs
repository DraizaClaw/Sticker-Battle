using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ButtonFunctions : MonoBehaviour // its mine so it passes automatically
{
    //

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }


    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }


    public void PlayGame()
    {
        SceneManager.LoadScene("Loading");
    }






}
