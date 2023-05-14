using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject dango;
    public float fallSpeed = 5f;
    public float interval = 1f;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // タイマーの更新
        timer += Time.deltaTime;

        // タイマーがインターバルを超えたら，画面上部からランダムにボールを生成
        if (timer >= interval)
        {
            timer = 0f;

            Vector3 position = new Vector3(Random.Range(-9f, 9f), 5f, 0f);
            GameObject ball = Instantiate(dango, position, Quaternion.identity);

            Rigidbody2D ballRigidbody = ball.GetComponent<Rigidbody2D>();
            ballRigidbody.velocity = new Vector2(0f, -fallSpeed);
        }
    }
}
