using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DangoEliminator : MonoBehaviour
{
    //DangoEliminatorのTransformを入れる変数
    private Transform eliminatorTransform;

    // Start is called before the first frame update
    void Start()
    {
        //Transformを取得
        eliminatorTransform = this.gameObject.GetComponent<Transform>();
        
        //オブジェクトと線対象の位置を代入
        //オブジェクトのスタート位置が右端と左端のどちらでも同じ動きをさせるため
        float moveDistination = -eliminatorTransform.position.x;

        //オブジェクトの移動を制御
        eliminatorTransform.DOLocalMoveX(moveDistination, 10.0f)
           .SetEase(Ease.InOutQuad)
           .SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
