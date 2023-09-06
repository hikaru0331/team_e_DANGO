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

    //煙パーティクルの取得
    [SerializeField] private GameObject smokeParticle;

    //タヌキ登場までの時間を設定するための変数
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

        //タヌキ生成までの時間をランダムで決定
        raccoonInterval = Random.Range(5.0f, 5.0f);
    }

    //タヌキをアクティブにするメソッド
    private void RaccoonSet()
    {
        dustBox.gameObject.SetActive(false);
        raccoon.gameObject.SetActive(true);

        //StartCoroutine(PauseTween(1.0f));

        //煙パーティクルの生成・破壊
        GameObject smokeParticleClone = Instantiate(smokeParticle, this.gameObject.transform.position, Quaternion.identity);
        Destroy(smokeParticleClone, 2.0f);
    }

    //ゴミ箱をアクティブにするメソッド
    public void DustBoxSet()
    {
        raccoon.gameObject.SetActive(false);
        dustBox.gameObject.SetActive(true);

        StartCoroutine(PauseTween(1.0f));

        //煙パーティクルの生成・破壊
        GameObject smokeParticleClone = Instantiate(smokeParticle, this.gameObject.transform.position, Quaternion.identity);
        Destroy(smokeParticleClone, 2.0f);

        //タヌキ生成までの時間をランダムで決定
        raccoonInterval = Random.Range(45.0f, 120.0f);
    }

    //Tweenを一時停止するコルーチン
    IEnumerator PauseTween(float pauseTime)
    {
        eliminatorTransform.DOPause();

        yield return new WaitForSeconds(pauseTime);

        eliminatorTransform.DOPlay();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= raccoonInterval)
        {
            //タヌキのオブジェクトが非アクティブの時に実行する
            if (!raccoon.gameObject.activeInHierarchy)
            {
                RaccoonSet();
                timer = 0;
            }                    
        }
    }
}
