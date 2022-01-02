using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public GameObject ScoreTrigger;

    private void Update()
    {
        string score = ScoreTrigger.GetComponent<ScoreScript>().score.ToString();

        GetComponent<Text>().text = score;
    }
}
