using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DangoEliminator : MonoBehaviour
{
    //DangoEliminatorのTransformを入れる変数
    private Transform eliminatorTransform;

    //子オブジェクトのゴミ箱とタヌキを参照するための変数
    [SerializeField] private GameObject dustBox;
    [SerializeField] private GameObject raccoon;

    private float timer;
    private float raccoonInterval;

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

    private void RaccoonSetter()
    {
        dustBox.gameObject.SetActive(false);
        raccoon.gameObject.SetActive(true);
    }

    public void DustBoxSetter()
    {
        raccoon.gameObject.SetActive(false);
        dustBox.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        raccoonInterval = Random.Range(45.0f, 90.0f);

        if (timer >= raccoonInterval)
        {
            RaccoonSetter();
        }
    }
}
