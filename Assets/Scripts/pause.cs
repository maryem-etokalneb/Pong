using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class pause : MonoBehaviour
{
    public GameObject Panel_pause;
     public void PauseGame(){
       Time.timeScale = 0;
       Panel_pause.SetActive(true);
    }

    public void menuPage(){
      SceneManager.LoadScene(0);
    }
    public void play(){
       Time.timeScale =1;
       Panel_pause.SetActive(false);


    }
}
