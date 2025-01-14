using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public AudioClip doorEffect;

    private bool player1Ready=false;
    private bool player2Ready=false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1"))
        {
            player1Ready = true;
            AudioSource.PlayClipAtPoint(doorEffect, transform.position);
        }
        else if (collision.CompareTag("Player2"))
        {
            player2Ready = true;
            AudioSource.PlayClipAtPoint(doorEffect, transform.position);
        }

        if (player1Ready &&  player2Ready)
        {
            string currentScene = SceneManager.GetActiveScene().name;
            if (currentScene=="Level1")
            {
                SceneManager.LoadScene("Level2");
            }
            else if (currentScene=="Level2")
            {
                SceneManager.LoadScene("EndGame");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1"))
        {
            player1Ready = false;
        }
        else if (collision.CompareTag("Player2"))
        {
            player2Ready = false;
        }
    }
}
