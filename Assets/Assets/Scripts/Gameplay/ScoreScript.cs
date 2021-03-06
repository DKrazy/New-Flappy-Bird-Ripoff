using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public GameObject Cube;
    public GameObject Wall;

    float wallSpeed;

    public int score = 0;
    public int highscore = 0;

    private void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore");
    }

    void FixedUpdate()
    {
        wallSpeed = Wall.GetComponent<Walls>().wallSpeed;
        GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x - wallSpeed, 0, 0);
    }

    private void Update()
    {
        if(Cube.GetComponent<Cube>().isDead == true && score > highscore)
        {
            highscore = score;

            PlayerPrefs.SetInt("highscore", highscore);
            PlayerPrefs.Save();
        }
    }
}
