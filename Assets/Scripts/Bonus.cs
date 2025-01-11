using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
	private ScoreManager scoreManager;
	public AudioClip collectSound;

	private void Awake()
	{
		scoreManager =FindObjectOfType<ScoreManager>();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag=="Player1" || collision.tag=="Player2")
		{
			scoreManager.IncrementPlayerScore();
			AudioSource.PlayClipAtPoint(collectSound, transform.position);
			gameObject.SetActive(false);
		}
    }
}
