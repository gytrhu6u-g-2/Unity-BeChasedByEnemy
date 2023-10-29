using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // シーンのリセットに必要

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private VariableJoystick joystick;

    [SerializeField] private int moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Rigidbodyで何かを動かす場合は、FixedUpdateを使う
    void FixedUpdate()
    {
        PlayerMove();
    }

    // playerの移動
    private void PlayerMove()
    {
        // 横移動
        float x = joystick.Horizontal;
        // 縦移動
        float y = joystick.Vertical;

        rb.velocity = new Vector3(x, y, 0) * moveSpeed * Time.deltaTime;
    }

    // 衝突したらゲームのリセット
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 今の画面を取得してリセット
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
