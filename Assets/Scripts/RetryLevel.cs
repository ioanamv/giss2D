using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryLevel : MonoBehaviour
{
    public static string RetryLevelName;

    public void GetLevelName(string levelName)
    {
        RetryLevelName=levelName;
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(RetryLevelName);
    }
}
