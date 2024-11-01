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
		if (collision.tag=="Player")
		{
			scoreManager.IncrementPlayerScore();
			AudioSource.PlayClipAtPoint(collectSound, transform.position);
			gameObject.SetActive(false);
		}
	}
}
