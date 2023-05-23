using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject dangoG;
    public GameObject dangoR;
    public GameObject dangoW;
    public float fallSpeed = 5f;
    public float intervalG = 1f;
    public float intervalR = 2f;
    public float intervalW = 3f;
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
        if (timer >= intervalG)
        {

            //dangoG
            Vector3 positionG = new Vector3(Random.Range(-9f, 9f), 5f, 0f);
            GameObject ballG = Instantiate(dangoG, positionG, Quaternion.identity);

            Rigidbody2D ballGRigidbody = ballG.GetComponent<Rigidbody2D>();

            ballGRigidbody.velocity = new Vector2(0f, -fallSpeed);

            //インターバルの更新
            intervalG += 3f;
        }

        if (timer >= intervalR)
        {
            //dangoR
            Vector3 positionR = new Vector3(Random.Range(-9f, 9f), 5f, 0f);
            GameObject ballR = Instantiate(dangoR, positionR, Quaternion.identity);

            Rigidbody2D ballRRigidbody = ballR.GetComponent<Rigidbody2D>();

            ballRRigidbody.velocity = new Vector2(0f, -fallSpeed);

            //インターバルの更新
            intervalR += 3f;
        }

        if (timer >= intervalW)
        {

            //dangoW
            Vector3 positionW = new Vector3(Random.Range(-9f, 9f), 5f, 0f);
            GameObject ballW = Instantiate(dangoW, positionW, Quaternion.identity);

            Rigidbody2D ballWRigidbody = ballW.GetComponent<Rigidbody2D>();

            ballWRigidbody.velocity = new Vector2(0f, -fallSpeed);

            //インターバルの更新
            intervalW += 3f;
        }

    }
}