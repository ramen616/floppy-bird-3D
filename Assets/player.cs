using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float upForce = 200f;  // ジャンプの力
    private Rigidbody rb;  // Rigidbodyコンポーネントへの参照

    void Start()
    {
        rb = GetComponent<Rigidbody>();  // Rigidbodyコンポーネントを取得
    }

    void Update()
    {
        // スペースキーが押されたとき
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector3.zero;  // 鳥の現在の速度をリセット
            rb.AddForce(Vector3.up * upForce);  // 上方向に力を加える
        }
    }

    // 障害物に衝突したときの処理
    void OnCollisionEnter(Collision collision)
    {
            Destroy(gameObject);
 }
}
