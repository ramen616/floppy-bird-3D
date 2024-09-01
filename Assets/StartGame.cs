using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // シーン管理用

public class StartGame : MonoBehaviour
{
    public void StartGameButton()
    {
        // ゲームのメインシーンをロードします（例: "MainScene"）
        SceneManager.LoadScene("Scenes/SampleScene");
    }
}