using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slippery : MonoBehaviour
{
    public float slipperySpeedMultiplier = 2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1"))
        {
            Player1 player1= collision.GetComponent<Player1>();
            if (player1 != null )
            {
                player1.SetSpeedMultiplier(slipperySpeedMultiplier);
            }
        }

        if (collision.CompareTag("Player2"))
        {
            Player2 player2 = collision.GetComponent<Player2>();
            if (player2 != null)
            {
                player2.SetSpeedMultiplier(slipperySpeedMultiplier);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1"))
        {
            Player1 player1 = collision.GetComponent<Player1>();
            if (player1 != null)
            {
                player1.SetSpeedMultiplier(1);
            }
        }

        if (collision.CompareTag("Player2"))
        {
            Player2 player2 = collision.GetComponent<Player2>();
            if (player2 != null)
            {
                player2.SetSpeedMultiplier(1);
            }
        }
    }
}
