using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

//Filter３種の親クラス
public class Filter : MonoBehaviour
{
    //親オブジェクトのTransformを入れる変数
    private Transform parentTransform;

    // Start is called before the first frame update
    void Start()
    {
        //親オブジェクトのTransformを取得
        parentTransform = transform.parent.GetComponent<Transform>();
        //親オブジェクトと線対象の位置を代入
        float moveDistination = -parentTransform.position.x;

        //親オブジェクトの移動を制御
        parentTransform.DOLocalMoveX(moveDistination, 3.0f)
           .SetEase(Ease.InOutQuad)
           .SetLoops(-1, LoopType.Yoyo);
    }

    //Filter３種に入れる抽象メソッド
    //ダンゴの色を変えるためのメソッド
    protected virtual void ChangeDangoColor()
    {
        Debug.Log("オーバーライドが実行されていません");
    }

}
