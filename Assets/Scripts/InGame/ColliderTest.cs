using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColliderTest : MonoBehaviour
{
    private int score;
    public Sprite dangoSprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //インターフェースとして用意したクラスのインスタンス化
        //ダンゴに直接アタッチされていないが、アタッチされているクラス(DangoGなど)の親クラスのため取得可能
        IDangoInfo dangoInfo = collision.gameObject.GetComponent<IDangoInfo>();

        if (dangoInfo != null)
        {
            score += dangoInfo.Point;
            Debug.Log(score); 
            Destroy(collision.gameObject);
        }

        //ゴールにダンゴが刺される処理
        //触れてきたオブジェクトのSpriteの情報を取得→ゴールのSpriteに代入
        //ここでは簡易化のために串のSpriteそのものをダンゴに変更している
        SpriteRenderer spriteRenderer = collision.gameObject.GetComponent<SpriteRenderer>();
        dangoSprite = spriteRenderer.sprite;
        
        this.gameObject.GetComponent<SpriteRenderer>().sprite = dangoSprite;

    }

}
