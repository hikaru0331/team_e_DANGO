using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DustBox : MonoBehaviour
{
    //ゴミ箱の親オブジェクトのTransformを入れる変数
    //ゴミ箱本体と削除判定をするコライダーを別オブジェクトにしているため
    private Transform parentTransform;

    // Start is called before the first frame update
    void Start()
    {
        //親オブジェクトのTransformを取得
        parentTransform = transform.parent.GetComponent<Transform>();
        //親オブジェクトと線対象の位置を代入
        float moveDistination = -parentTransform.position.x;

        //親オブジェクトの移動を制御
        parentTransform.DOLocalMoveX(moveDistination, 10.0f)
           .SetEase(Ease.InOutQuad)
           .SetLoops(-1, LoopType.Yoyo);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //ぶつかってきたオブジェクトを破壊
        Destroy(collision.gameObject);
    }
}
