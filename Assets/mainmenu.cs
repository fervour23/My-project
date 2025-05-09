using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene(1);
    }
    public void Quit(){
        Application.Quit();
    }
    public void screen(){
        SceneManager.LoadScene(0);
    }
    public void PlayGame2(){
        SceneManager.LoadScene(2);
    }
    public void PlayGame3(){
        SceneManager.LoadScene(3);
    }
}
