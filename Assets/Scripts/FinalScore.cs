using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class FinalScore : MonoBehaviour
{
    private TextMeshProUGUI finalScore;
    void Start()
    {
        finalScore = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerLives.gameIsOver == true)
        {
            finalScore.text = "Your score: " + ScoreCounter.Score.ToString();
        }
    }
}
