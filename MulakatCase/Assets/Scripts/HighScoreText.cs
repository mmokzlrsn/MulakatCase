using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreText : MonoBehaviour
{
    public void SetHighScoreText(int score)
    {
        GetComponent<TextMeshProUGUI>().text = $"HighScore: {PlayerPrefs.GetInt("HighScore")}";
    }
}
