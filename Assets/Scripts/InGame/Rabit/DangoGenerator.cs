using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangoGenerator : MonoBehaviour
{
    //団子生成場所のゲームオブジェクトを入れる変数
    public GameObject generatePosition;

    //団子生成にかかわる変数
    public GameObject dango;
    private float timer;
    public float interval;
    private GameObject generatedDango;

    //RabitAnimatorクラスの取得
    RabitAnimator rabitAnimator;

    // Start is called before the first frame update
    void Start()
    {
        rabitAnimator = GetComponent<RabitAnimator>();
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if (timer >= interval)
        {
            timer = 0;

            //RabitAnimatorクラスにあるSpriteRendererコンポーネントにアクセス
            //スプライトをRabitAnimatorクラスのshotSpriteに変更
            rabitAnimator.rabitSprite.sprite = rabitAnimator.shotSprite;
            //だんご生成
            generatedDango = Instantiate(dango, generatePosition.gameObject.transform.position, Quaternion.identity);

            //スプライトをRabitAnimatorクラスのidleSpriteに戻す処理を呼び出す
            rabitAnimator.Invoke("SpriteResetter", 0.2f);
        }
    }
}
