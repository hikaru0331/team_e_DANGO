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

    [SerializeField] private GameObject feverTimeCanvas;
    [SerializeField] private TMP_Text feverTimerText;
    private float feverTimer;

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
            //毒ダンゴ食事時のスプライトに変更し、1.0f動きを止める
            raccoonAnimation.poisonEatAnimation();
            StartCoroutine(dangoEliminator.PauseTween(1.0f));

            yield return new WaitForSeconds(1.0f);

            //1.0f後にフィーバー実行
            FeverSet();
            dangoEliminator.DustBoxSet();

            dangoEatCount = 0;

            //タヌキの画像を通常時にリセット
            raccoonAnimation.raccoonSpriteReset();
        }
        else if (dangoEatCount >= 5)
        {
            StartCoroutine(dangoEliminator.PauseTween(1.0f));

            yield return new WaitForSeconds(1.0f);

            //1.0f後にゴミ箱に変身
            dangoEliminator.DustBoxSet();

            dangoEatCount = 0;

            //タヌキの画像を通常時にリセット
            raccoonAnimation.raccoonSpriteReset();
        }

        raccoonCollider.enabled = true;
    }

    private void FeverSet()
    {
        //フィーバー移行時の演出

        dangoLottery.FeverDictionary();

        feverTimer = 30.0f;
        feverTimeCanvas.SetActive(true);

        dangoLottery.Invoke("InitializeDictionary", 30.0f);
    }

    private void Update()
    {
        feverTimer -= Time.deltaTime;
        feverTimerText.text = "FeverTime: " + feverTimer.ToString();

        if (feverTimer <= 0)
        {
            feverTimeCanvas.SetActive(false);
        }
    }
}
