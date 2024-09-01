using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public Vector3 startPosition = new Vector3(0, 1, -10); // 初期位置
    public Vector3 midPosition = new Vector3(0, 1, -10);   // 5秒後の位置（変更なし）
    public Vector3 endPosition = new Vector3(-20, 1, 0);    // 最終位置
    public Quaternion startRotation = Quaternion.Euler(0, 0, 0); // 初期回転
    public Quaternion endRotation = Quaternion.Euler(0, 90, 0);   // 最終回転
    public float waitTime = 30f; // 20秒間待機

    private float elapsedTime = 0f; // 経過時間を追跡するための変数
    private bool hasMoved = false;  // 位置と回転が移動したかどうかのフラグ

    private void Start()
    {
        // カメラの初期位置と回転を設定
        transform.position = startPosition;
        transform.rotation = startRotation;
    }

    private void Update()
    {
        // 経過時間を増加
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= waitTime)
        {
            // 5秒経過後、位置と回転を変更
            if (!hasMoved)
            {
                float t = (elapsedTime - waitTime) / (waitTime / 2f); // 残り時間に応じて補間
                transform.position = Vector3.Lerp(midPosition, endPosition, t);
                transform.rotation = Quaternion.Lerp(startRotation, endRotation, t);

                // 位置と回転が変更されたことを記録
                if (elapsedTime - waitTime >= waitTime / 2f)
                {
                    hasMoved = true;
                }
            }
        }
    }
}
