using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] float wallSpeed;

    [SerializeField] public int score = 0;

    void FixedUpdate()
    {
        GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x - wallSpeed, 0, 0);
    }
}
