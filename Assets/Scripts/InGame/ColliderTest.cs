using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColliderTest : MonoBehaviour
{
    private int score;
    [System.NonSerialized] public Sprite dangoSprite;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //インターフェースとして用意したクラスのインスタンス化
        //ダンゴに直接アタッチされていないが、アタッチされているクラス(DangoGなど)の親クラスのため取得可能
        IDangoInfo dangoInfo = collision.gameObject.GetComponent<IDangoInfo>();

        if (dangoInfo != null)
        {
            //ダンゴに格納されているスコア情報を取得して加算する処理
            score += dangoInfo.Point;
            Debug.Log(score);

            //ゴールにダンゴが刺される処理
            //触れてきたオブジェクトのSpriteの情報を取得→ゴールのSpriteに代入
            //ここでは簡易化のために串のSpriteそのものをダンゴに変更している
            this.gameObject.GetComponent<SpriteRenderer>().sprite = dangoInfo.Sprite;

            //毒ダンゴだったときにゲームオーバーにする処理
            if (dangoInfo.Attribute == "Poison")
            {
                Debug.Log("GameOver");
            }

            Destroy(collision.gameObject);
        }
        
    }

}
