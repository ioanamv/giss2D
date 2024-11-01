using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
	public TextMeshProUGUI playerScoreText;
	private int playerScore=0;
    
    void Start()
    {
        playerScore = 0;
        UpdateScoreText();
	}

    public void IncrementPlayerScore()
    {
        playerScore++;
        UpdateScoreText();
	}

    private void UpdateScoreText()
    {
        playerScoreText.text = "Player score: "+playerScore.ToString();
    }
}
