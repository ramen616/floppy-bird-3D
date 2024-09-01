using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;  // TextMeshProを使用する場合はこれが必要


public class TitleScreenManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // スコアを表示するためのUIテキスト

    private void Start()
    {
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        if (GameManager.Instance != null)
        {
            scoreText.text = "Score: " + GameManager.Instance.Score.ToString();
        }
        else
        {
            scoreText.text = "Score: 0";
        }
    }
}