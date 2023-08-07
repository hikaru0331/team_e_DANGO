using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirdDango : MonoBehaviour
{
    //このオブジェクトのImageコンポーネントを入れる変数
    private Image thirdImage;

    //DangoLotteryクラスの取得
    [SerializeField] private GameObject dangoLotteryObj;
    private DangoLottery dangoLottery;

    //抽選結果のダンゴオブジェクトを入れる変数
    [System.NonSerialized] public GameObject thirdDango;
    
    // Start is called before the first frame update
    void Start()
    {
        thirdImage = this.GetComponent<Image>();

        dangoLottery = dangoLotteryObj.GetComponent<DangoLottery>();
    }

    public GameObject ChooseThirdDango()
    {
        thirdDango = dangoLottery.ChooseDango();
        SpriteRenderer thirdRenderer = thirdDango.GetComponent<SpriteRenderer>();

        thirdImage.sprite = thirdRenderer.sprite;

        return thirdDango;
    }

}
