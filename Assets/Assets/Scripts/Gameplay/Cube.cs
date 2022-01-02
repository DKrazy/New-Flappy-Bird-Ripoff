using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cube : MonoBehaviour
{
    public GameObject Score;
    public GameObject ScoreDetector;

    public GameObject Walls1;
    public GameObject Walls2;
    public GameObject Walls3;
    public GameObject Walls4;

    public ParticleSystem Particles;

    public AudioClip jump;
    public AudioClip death;

    int wall = 1;

    public float timer;

    public bool isDead = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(transform.up * 300, ForceMode2D.Force);

            GetComponent<AudioSource>().PlayOneShot(jump, 0.5f);
        }

        if (isDead && timer <= 0)
        {
            SceneManager.LoadScene("Menu");
        }

        timer = timer - Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;

        GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<Rigidbody2D>().AddForce(transform.up * 100, ForceMode2D.Force);

        Particles.GetComponent<ParticleSystem>().Play();

        GetComponent<AudioSource>().PlayOneShot(death, 1f);

        timer = 3;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        ScoreDetector.GetComponent<ScoreScript>().score++;

        wall++;

        if(wall == 1)
        {
            ScoreDetector.GetComponent<Transform>().position = new Vector3(Walls1.GetComponent<Transform>().position.x + 0.25f, 0, 0);
        }
        else if(wall == 2)
        {
            ScoreDetector.GetComponent<Transform>().position = new Vector3(Walls2.GetComponent<Transform>().position.x + 0.25f, 0, 0);
        }
        else if (wall == 3)
        {
            ScoreDetector.GetComponent<Transform>().position = new Vector3(Walls3.GetComponent<Transform>().position.x + 0.25f, 0, 0);
        }
        else if (wall == 4)
        {
            ScoreDetector.GetComponent<Transform>().position = new Vector3(Walls4.GetComponent<Transform>().position.x + 0.25f, 0, 0);
        }
        else
        {
            ScoreDetector.GetComponent<Transform>().position = new Vector3(Walls1.GetComponent<Transform>().position.x + 0.25f, 0, 0);
            wall = 1;
        }
    }
}
