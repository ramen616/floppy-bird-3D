using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;  // パイプのプレハブ
    public float spawnRate = 2f;   // パイプが生成される間隔
    public float heightOffset = 2f;  // パイプの高さのオフセット

    private float timer = 0f;

    void Start()
    {
        // 初回のパイプをすぐに生成する
        SpawnPipe();
    }

    void Update()
    {
        // タイマーを増加させる
        timer += Time.deltaTime;

        // タイマーが生成間隔に達したらパイプを生成
        if (timer >= spawnRate)
        {
            SpawnPipe();
            timer = 0f;  // タイマーをリセット
        }

    }

    void SpawnPipe()
    {
        // ランダムな高さを計算
        float randomHeight = Random.Range(-heightOffset, heightOffset);
        
        // パイプを生成し、ランダムな高さに配置
        Instantiate(pipePrefab, new Vector3(15f, randomHeight, 0f), Quaternion.identity).SetActive(true);

    }
}
