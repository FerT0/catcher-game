using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    private TextMeshProUGUI scoreCounterText;
    public static int Score;

    void Start()
    {
        scoreCounterText = GetComponent<TextMeshProUGUI>();
        Score = 0;
    }

    void Update()
    {
        scoreCounterText.text = Score.ToString();
    }
}
