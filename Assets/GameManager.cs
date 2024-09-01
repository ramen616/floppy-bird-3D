using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // シーン管理に必要な名前空間

public class GameManager : MonoBehaviour
{
    // シングルトンインスタンスを保持する静的プロパティ
    public static GameManager Instance { get; private set; }

    // スコアを保持するプロパティ
    public int Score { get; private set; }

    private void Awake()
    {
        // シングルトンインスタンスが設定されていない場合は設定する
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // シーンがロードされてもこのオブジェクトを削除しない
        }
        else
        {
            Destroy(gameObject); // 既にインスタンスがある場合、このオブジェクトを破棄する
        }
    }

    // スコアを増加させるメソッド
    public void AddScore(int points)
    {
        Score += points;
    }

    // スコアをリセットするメソッド
    public void ResetScore()
    {
        Score = 0;
    }
}