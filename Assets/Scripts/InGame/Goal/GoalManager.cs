using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    public IDangoInfo dangoInfo;

    private ScoreManager scoreManager;
    private GoalSpriteManager goalSpriteManager;

    private void Start()
    {
        scoreManager = this.gameObject.GetComponent<ScoreManager>();
        goalSpriteManager = this.gameObject.GetComponent<GoalSpriteManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //インターフェースとして用意したクラスのインスタンス化
        //ダンゴに直接アタッチされていないが、アタッチされているクラス(DangoGなど)の親クラスのため取得可能
        dangoInfo = collision.gameObject.GetComponent<IDangoInfo>();

        if (dangoInfo != null)
        {
            //ScoreManagerクラスのスコア計算メソッドにスコアを渡す
            scoreManager.PointCalculator(dangoInfo.Point);

            //SpriteManagerクラスのスプライト変換メソッドにスコアを渡す
            goalSpriteManager.SpriteChanger(dangoInfo.Sprite);

            //毒ダンゴだったときにゲームオーバーにする処理
            if (dangoInfo.Attribute == "Poison")
            {
                //Debug.Log("GameOver");
            }

            Destroy(collision.gameObject);
        }

    }

}
