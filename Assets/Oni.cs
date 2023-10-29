using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oni : MonoBehaviour
{
    // オブジェクトの取得
    [SerializeField] private GameObject player;
    // スピード
    [SerializeField] private int moveSpeed;

    // Update is called once per frame
    void Update()
    {
        // 敵が追いかけてくる処理
        transform.position = Vector3.MoveTowards(
            transform.position, // 追尾(移動)したいオブジェクトのポジション
            player.transform.position, // ターゲットのポジション
            moveSpeed * Time.deltaTime // 移動速度
            );
    }
}
