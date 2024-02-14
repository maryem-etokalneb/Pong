using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        try
        {
            SceneManager.LoadScene("level1");
            
        }
        catch (System.Exception)
        { 
            throw;
        }
        
    }
    public void QuitGame(){
        Application.Quit();
    }
}
