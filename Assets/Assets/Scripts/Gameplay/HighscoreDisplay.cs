using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreDisplay : MonoBehaviour
{
    public GameObject ScoreDetector;

    private void Update()
    {
        GetComponent<Text>().text = "Highscore: " + ScoreDetector.GetComponent<ScoreScript>().highscore.ToString();
    }
}
