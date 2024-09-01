using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // TextMeshProを使用する場合はこれが必要
using UnityEngine.SceneManagement;  // シーン管理のために必要

public class ScoreManager : MonoBehaviour
{
    public int score = 0;  // スコアの初期値
    public TextMeshProUGUI scoreText;  // スコアを表示するためのUIテキスト
    public int scoreToWin = 777;  // スコアがこの値を超えたらタイトルに移動する

    private float timeElapsed = 0f;  // 経過時間を追跡するための変数
    private float scoreInterval = 0.1f;  // スコアが増加する間隔（秒）

    void Start()
    {
        // 初期スコアを表示
        UpdateScoreText();
    }

    void Update()
    {
        // 経過時間を加算
        timeElapsed += Time.deltaTime;

        // 経過時間が指定した間隔を超えた場合
        if (timeElapsed >= scoreInterval)
        {
            AddScore(1);  // スコアを増やす
            timeElapsed = 0f;  // 経過時間をリセット
        }
        
        // スコアが目標値を超えた場合
        if (score >= scoreToWin)
        {
            // タイトルシーンに移動する
            SceneManager.LoadScene("ClearScene"); // "TitleScene" はタイトルシーンの名前
        }
    }

    // スコアを増やし、表示を更新する
    public void AddScore(int value)
    {
        score += value;
        UpdateScoreText();
    }

    // スコアの表示を更新する
    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}