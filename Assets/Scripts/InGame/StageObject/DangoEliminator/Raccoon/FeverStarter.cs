using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            raccoonAnimation.poisonEatAnimation();
            StartCoroutine(dangoEliminator.PauseTween(1.0f));

            yield return new WaitForSeconds(1.0f);

            FeverSet();
            dangoEliminator.DustBoxSet();

            dangoEatCount = 0;

            raccoonAnimation.raccoonSpriteReset();
        }
        else if (dangoEatCount >= 5)
        {
            StartCoroutine(dangoEliminator.PauseTween(1.0f));

            yield return new WaitForSeconds(1.0f);

            dangoEliminator.DustBoxSet();

            dangoEatCount = 0;

            raccoonAnimation.raccoonSpriteReset();
        }

        raccoonCollider.enabled = true;
    }

    private void FeverSet()
    {
        //フィーバー移行時の演出

        dangoLottery.FeverDictionary();

        dangoLottery.Invoke("InitializeDictionary", 30.0f);
    }
}
