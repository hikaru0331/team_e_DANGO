using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondDango : MonoBehaviour
{
    //このオブジェクトのImageコンポーネントを入れる変数
    private Image secondImage;

    //DangoLotteryクラスの取得
    [SerializeField] private GameObject thirdDangoObj;
    private ThirdDango thirdDango;

    //抽選結果のダンゴオブジェクトを入れる変数
    [System.NonSerialized] public GameObject secondDango;

    // Start is called before the first frame update
    void Start()
    {
        secondImage = this.GetComponent<Image>();

        thirdDango = thirdDangoObj.GetComponent<ThirdDango>();

        ChooseSecondDango();
    }

    public GameObject ChooseSecondDango()
    {
        secondDango = thirdDango.ChooseThirdDango();
        SpriteRenderer secondRenderer = secondDango.GetComponent<SpriteRenderer>();

        secondImage.sprite = secondRenderer.sprite;

        return secondDango;
    }

}
