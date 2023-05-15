using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void Quit()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }

    
}
