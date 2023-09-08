using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RaccoonAnimation : MonoBehaviour
{
    //タヌキオブジェクトの取得
    private SpriteRenderer raccoonSprite;

    //タヌキが持つダンゴのオブジェクトの取得
    [SerializeField] private GameObject dangoPosition;
    private SpriteRenderer positionSprite;

    //タヌキ画像差分を入れる配列
    [SerializeField] private Sprite[] raccoonSprites;

    //親オブジェクトのDangoEliminatorクラスの取得
    DangoEliminator dangoEliminator;

    //食事中のパーティクルを入れる配列
    [SerializeField] private GameObject[] eatParticles;

    private void Start()
    {
        //タヌキオブジェクトのRendererの取得
        raccoonSprite = this.gameObject.GetComponent<SpriteRenderer>();

        //タヌキが持つダンゴオブジェクトのRenderer取得
        positionSprite = dangoPosition.GetComponent<SpriteRenderer>();

        //親オブジェクトのDangoEliminatorクラスの取得
        dangoEliminator = transform.parent.gameObject.GetComponent<DangoEliminator>();
    }

    public void EatAnimation(Sprite dangoSprite, string dangoColor)
    {
        //タヌキの手元にぶつかってきたダンゴの画像を代入
        positionSprite.sprite = dangoSprite;
        //タヌキの画像を食事中に変更
        raccoonSprite.sprite = raccoonSprites[1];

        //タヌキの移動を一時停止
        StartCoroutine(dangoEliminator.PauseTween(1.0f));

        GameObject instantiaterParticle = null;
        
        //ダンゴの色に応じたパーティクルの生成
        switch (dangoColor)
        {
            case "Green":
                instantiaterParticle = Instantiate(eatParticles[0], dangoPosition.transform);
                break;

            case "Red":
                instantiaterParticle = Instantiate(eatParticles[1], dangoPosition.transform);
                break;

            case "White":
                instantiaterParticle = Instantiate(eatParticles[2], dangoPosition.transform);
                break;
        }

        //パーティクルを１秒後に破壊
        Destroy(instantiaterParticle, 1.0f);

        //ダンゴをだんだん小さくする処理
        dangoPosition.transform.DOScale(new Vector2(0.0f, 0.0f), 1.0f);

    }
}
