using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangoRain : MonoBehaviour
{
    public GameObject[] dangoPrefabs;
    public Transform spawnPoint;
    public ScoreDisplay scoreDisplay;   // スコア表示用のスクリプト

    private float fallSpeed = 2f;
    private float totalScore;
    private int scoreThereshold = 500;  // 500点以上で落ちてくる
    private ScoreManager scoreManager;

    // Start is called before the first frame update
    private void Start()
    {
        scoreManager = new ScoreManager();
        totalScore = scoreManager.totalScore;   // ゲーム終了時のスコアを取得
        totalScore = 10000;   // テスト用にスコアを500に設定
        if (totalScore >= scoreThereshold)
        {
            StartDangoRain();
        }
    }

    public void StartDangoRain()
    {
        StartCoroutine(DropDangos());
    }

    private IEnumerator DropDangos()
    {
        int dangosSpawned = 0;  // 生成した団子の数
        int maxDangosWithScore = Mathf.FloorToInt(totalScore / scoreThereshold);    // 生成する団子の数
        float delay = 0.2f; // 団子を生成する間隔

        while (dangosSpawned < maxDangosWithScore)
        {
            if (totalScore >= scoreThereshold)
            {
                // 生成する団子の種類をランダムに決定
                int randomDangoIndex = Random.Range(0, dangoPrefabs.Length);

                // 生成する団子の位置をランダムに決定
                Vector3 randomSpawnPosition = new Vector3(Random.Range(-1f, 1f), spawnPoint.position.y, spawnPoint.position.z);

                // 団子を生成
                GameObject dango = Instantiate(dangoPrefabs[randomDangoIndex], randomSpawnPosition, Quaternion.identity);

                // 団子のスケールを変更
                dango.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);

                // 団子にアタッチされたRigidbody2Dコンポーネントを取得し、降下速度を設定
                Rigidbody2D rb = dango.GetComponent<Rigidbody2D>();
                rb.velocity = Vector2.down * fallSpeed;

                dangosSpawned++;
            }

            yield return new WaitForSeconds(delay); // delay秒待つ

            scoreDisplay.ShowScore(totalScore);    // スコアを表示
        }
    }

}
