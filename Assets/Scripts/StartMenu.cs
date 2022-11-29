using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Korzystamy z biblioteki SceneManagement

public class StartMenu : MonoBehaviour
{
   public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //Ładujemy scene która jest następna w buildzie - buildInex + 1
    }
}
