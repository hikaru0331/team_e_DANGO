using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeverStarter : MonoBehaviour
{
    private int dangoEatCount;

    private CapsuleCollider2D raccoonCollider;

    DangoEliminator dangoEliminator;

    [SerializeField] private GameObject dangoLotteryObj;
    private DangoLottery dangoLottery;

    private void Start()
    {
        raccoonCollider = GetComponent<CapsuleCollider2D>();

        dangoEliminator = GetComponentInParent<DangoEliminator>();
        dangoLottery = dangoLotteryObj.GetComponent<DangoLottery>();
    }

    public void DangoEat(string dangoAttribute)
    {
        dangoEatCount++;
        raccoonCollider.enabled = false;

        if (dangoAttribute == "Poison")
        {
            //��X�A�j���[�V�����Đ�����Invoke������
            FeverSet();
            dangoEliminator.DustBoxSet();

            dangoEatCount = 0;
        }
        else if (dangoEatCount >= 5)
        {
            //��X�A�j���[�V�����Đ�����Invoke������
            dangoEliminator.DustBoxSet();

            dangoEatCount = 0;
        }
    }

    private void FeverSet()
    {
        //�t�B�[�o�[�ڍs���̉��o

        dangoLottery.FeverDictionary();

        dangoLottery.Invoke("InitializeDictionary", 30.0f);
    }
}
