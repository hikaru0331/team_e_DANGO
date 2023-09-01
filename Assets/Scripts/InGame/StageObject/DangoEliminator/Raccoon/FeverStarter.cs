using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeverStarter : MonoBehaviour
{
    private int dangoEatCount;

    DangoEliminator dangoEliminator;

    [SerializeField] private GameObject dangoLotteryObj;
    private DangoLottery dangoLottery;

    private void Start()
    {
        dangoEliminator = GetComponentInParent<DangoEliminator>();
        dangoLottery = dangoLotteryObj.GetComponent<DangoLottery>();
    }

    public void DangoEat(string dangoAttribute)
    {
        dangoEatCount++;

        if (dangoAttribute == "Poison")
        {
            //後々アニメーション再生分のInvokeを入れる
            FeverSet();
            dangoEliminator.DustBoxSet();

            dangoEatCount = 0;
        }
        else if (dangoEatCount >= 5)
        {
            //後々アニメーション再生分のInvokeを入れる
            dangoEliminator.DustBoxSet();

            dangoEatCount = 0;
        }
    }

    private void FeverSet()
    {
        //フィーバー移行時の演出

        dangoLottery.FeverDictionary();

        dangoLottery.Invoke("InitializeDictionary", 30.0f);
    }
}
