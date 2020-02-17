using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bird : MonoBehaviour
{
    public Rigidbody2D birdRigidbody;
    // variable & variable name

    public float flapForce;
    public GameObject gameoverUI;

    int score = 0;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("flap is working");
            // ^ that was at one point a script but we can comment it out

            //birdRigidbody.AddForce(Vector2.up * flapForce ); 
            //using variable 'flapForce' instead of hard coding with a number


            birdRigidbody.velocity = Vector2.up * flapForce;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "ScoreTag")
        {
            score += 1;
            Debug.Log(score);
        }
        else
        {
            gameoverUI.SetActive(true);
            Time.timeScale = 1;
        }

        //Debug.Log("Collision");


    }

    public void OnRestartButtonPressed()
    {
        //Debug.Log("Button Pressed");
        SceneManager.LoadScene("SampleScene");
    }
}
