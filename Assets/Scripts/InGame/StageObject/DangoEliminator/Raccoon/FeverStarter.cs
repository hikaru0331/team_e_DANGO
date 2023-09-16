using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FeverStarter : MonoBehaviour
{
    private int dangoEatCount;

    private CapsuleCollider2D raccoonCollider;

    DangoEliminator dangoEliminator;

    RaccoonAnimation raccoonAnimation;

    [SerializeField] private GameObject dangoLotteryObj;
    private DangoLottery dangoLottery;

    private void Start()
    {
        raccoonCollider = GetComponent<CapsuleCollider2D>();

        dangoEliminator = GetComponentInParent<DangoEliminator>();
        raccoonAnimation = GetComponent<RaccoonAnimation>();

        dangoLottery = dangoLotteryObj.GetComponent<DangoLottery>();
    }

    public IEnumerator DangoEat(string dangoAttribute)
    {
        dangoEatCount++;
        raccoonCollider.enabled = false;

        yield return new WaitForSeconds(1.0f);

        if (dangoAttribute == "Poison")
        {
            //�Ń_���S�H�����̃X�v���C�g�ɕύX���A1.0f�������~�߂�
            raccoonAnimation.poisonEatAnimation();
            StartCoroutine(dangoEliminator.PauseTween(1.0f));

            yield return new WaitForSeconds(1.0f);

            //1.0f��Ƀt�B�[�o�[���s
            FeverSet();
            dangoEliminator.DustBoxSet();

            dangoEatCount = 0;

            //�^�k�L�̉摜��ʏ펞�Ƀ��Z�b�g
            raccoonAnimation.raccoonSpriteReset();
        }
        else if (dangoEatCount >= 5)
        {
            StartCoroutine(dangoEliminator.PauseTween(1.0f));

            yield return new WaitForSeconds(1.0f);

            //1.0f��ɃS�~���ɕϐg
            dangoEliminator.DustBoxSet();

            dangoEatCount = 0;

            //�^�k�L�̉摜��ʏ펞�Ƀ��Z�b�g
            raccoonAnimation.raccoonSpriteReset();
        }

        raccoonCollider.enabled = true;
    }

    private void FeverSet()
    {
        //�t�B�[�o�[�ڍs���̉��o
        dangoLottery.FeverDictionary();

        FeverTimerController.isFever = true;

        dangoLottery.Invoke("InitializeDictionary", 30.0f);
    }
}
