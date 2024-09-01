using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // シーン管理用

public class Clear : MonoBehaviour
{
    public void StartGameButton()
    {
        // ゲームのメインシーンをロードします（例: "MainScene"）
        SceneManager.LoadScene("TitleScene");
    }
}