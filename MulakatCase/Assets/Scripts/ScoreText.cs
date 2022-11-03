using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public void SetScoreText(int score)
    {
        GetComponent<TextMeshProUGUI>().text = $"Score: {score}";
    }

    
}
