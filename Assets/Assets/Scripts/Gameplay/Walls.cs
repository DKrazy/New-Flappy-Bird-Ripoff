using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    [SerializeField] float wallSpeed;

    float yRandom = 0;

    void FixedUpdate()
    {
        GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x - wallSpeed, yRandom, 0);

        if (GetComponent<Transform>().position.x <= -12)
        {
            GetComponent<Transform>().position = new Vector3(12, 0, 0);

            yRandom = Random.Range(-0.5f, 0.5f);
        }
    }
}
