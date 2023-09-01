using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaccoonController : MonoBehaviour
{
    private FeverStarter feverStarter;

    private void Start()
    {
        feverStarter = this.gameObject.GetComponent<FeverStarter>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //インターフェースとして用意したクラスのインスタンス化
        //ダンゴに直接アタッチされていないが、アタッチされているクラス(DangoGなど)の親クラスのため取得可能
        if (collision.gameObject.TryGetComponent<IDangoInfo>(out var dangoInfo))
        {
            feverStarter.DangoEat(dangoInfo.Attribute);

            Destroy(collision.gameObject);
        }
    }
}
