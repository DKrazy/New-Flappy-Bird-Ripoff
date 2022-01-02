using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    public GameObject ScoreDetector;

    float wallSpeed = 0.1f;

    float yRandom = 0;

    void FixedUpdate()
    {
        GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x - wallSpeed, yRandom, 0);

        if (GetComponent<Transform>().position.x <= -12)
        {
            GetComponent<Transform>().position = new Vector3(12, 0, 0);

            yRandom = Random.Range(-0.5f, 0.5f);
        }

        if(ScoreDetector.GetComponent<ScoreScript>().score < 20)
        {
            wallSpeed = 0.1f;
        }
        else if (ScoreDetector.GetComponent<ScoreScript>().score < 30)
        {
            wallSpeed = 0.15f;
        }
        else if (ScoreDetector.GetComponent<ScoreScript>().score < 40)
        {
            wallSpeed = 0.2f;
        }
        else if (ScoreDetector.GetComponent<ScoreScript>().score < 50)
        {
            wallSpeed = 0.25f;
        }
        else
        {
            wallSpeed = 0.3f;
        }
    }
}
