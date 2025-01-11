using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    public TextMeshProUGUI countdownText;
    public int countdownTime = 10;
    
    private float currentTime;
    private RetryLevel retryLevel;

    private void Awake()
    {
        retryLevel=FindObjectOfType<RetryLevel>();
    }

    private void Start()
    {
        currentTime = countdownTime;
        UpdateCountdownText();
    }

    private void Update()
    {
        if (currentTime>0)
        {
            currentTime-= Time.deltaTime;
            currentTime=Mathf.Max(currentTime, 0);
            UpdateCountdownText();
        }
        else
        {
            retryLevel.GetLevelName(SceneManager.GetActiveScene().name);
            SceneManager.LoadScene("RetryScene");
        }
    }

    private void UpdateCountdownText()
    {
        countdownText.text= "Time left: "+Mathf.Ceil(currentTime).ToString()+" seconds";
    }
}
