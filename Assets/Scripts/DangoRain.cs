using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangoRain : MonoBehaviour
{
    //private GameObject[] dangoPrefabs;
    private Transform spawnPoint;
    private float fallSpeed = 2f;
    private int scoreThereshold = 300;  // 300点以上で落ちてくる
    private int totalScore = 0;   // 現在のスコア
    //private int totalScore = インゲームのクラス.totalScore;
    private bool isRaining = false; // 落ちてくるかどうか

    // Start is called before the first frame update
    private void Start()
    {
        totalScore = 500;   // テスト用にスコアを500に設定
        if (totalScore >= scoreThereshold)
        {
            StartDangoRain();
        }
    }

    private void StartDangoRain()
    {
        isRaining = true;
        StartCoroutine(DropDangos());
    }

    private IEnumerator DropDangos()
    {
        int dangosSpawned = 0;  // 生成した団子の数
        int maxDangosWithScore = Mathf.FloorToInt(totalScore / scoreThereshold);    // 生成する団子の数

        while (dangosSpawned < maxDangosWithScore)
        {
            if (totalScore >= scoreThereshold)
            {
                // 生成する団子の種類をランダムに決定
                //int randomDangoIndex = Random.Range(0, dangoPrefabs.Length);

                // 生成する団子の位置をランダムに決定
                //GameObject dango = Instantiate(dangoPrefabs[randomDangoIndex], spawnPoint.position, Quaternion.identity);

                // 団子にアタッチされたRigidbody2Dコンポーネントを取得し、降下速度を設定
                //Rigidbody2D rb = dango.GetComponent<Rigidbody2D>();
                //rb.velocity = Vector2.down * fallSpeed;

                dangosSpawned++;
            }

            
        }
        
    }



}
