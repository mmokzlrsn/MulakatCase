using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour , IScore
{
    public void SetText(int score)
    {
        GetComponent<TextMeshProUGUI>().text = $"Score: {score}";
    }

    
}
