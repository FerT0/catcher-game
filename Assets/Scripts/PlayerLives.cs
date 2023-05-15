using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerLives : MonoBehaviour
{
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public static int Lives;
    public static bool gameIsOver;
    
    void Start()
    {
        Lives = 3;
        gameIsOver = false;
    }
    void Update()
    {
        if (Lives == 2)
        {
            Destroy(heart3);
        } else if (Lives == 1)
        {
            Destroy(heart2);
        } else if (Lives == 0)
        {
            Destroy(heart1);
            SceneManager.LoadScene("GameOver");
            gameIsOver = true;
        }
    }
}
