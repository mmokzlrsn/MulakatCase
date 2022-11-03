using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreText : MonoBehaviour, IScore
{
    private void Start()
    {
        GetComponent<TextMeshProUGUI>().text = $"High Score: {PlayerPrefs.GetInt("HighScore")}";
    }

    public void SetText(int score)
    {
        if(GameManager.Instance.CheckHighScore())
        GetComponent<TextMeshProUGUI>().text = $"High Score: {PlayerPrefs.GetInt("HighScore")}";
    }
}
