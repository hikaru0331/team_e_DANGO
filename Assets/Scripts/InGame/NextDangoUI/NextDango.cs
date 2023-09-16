using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextDango : MonoBehaviour
{
    //���̃I�u�W�F�N�g��Image�R���|�[�l���g������ϐ�
    private Image nextImage;

    //DangoLottery�N���X�̎擾
    [SerializeField] private GameObject dangoLotteryObj;
    private DangoLottery dangoLottery;

    //SecondDango�N���X�̎擾
    [SerializeField] private GameObject secondDangoObj;
    private SecondDango secondDango;

    //SecondDango���瓾���_���S�I�u�W�F�N�g������ϐ�
    [System.NonSerialized] public GameObject nextDango;
    private SpriteRenderer nextRenderer;

    // Start is called before the first frame update
    void Start()
    {
        //�R���|�[�l���g�̎擾
        nextImage = this.GetComponent<Image>();
        dangoLottery = dangoLotteryObj.GetComponent<DangoLottery>();

        secondDango = secondDangoObj.GetComponent<SecondDango>();

        //�Q�[���J�n����UI�ɕ\������_���S�����߂鏈��
        nextDango = dangoLottery.ChooseDango();
        nextRenderer = nextDango.GetComponent<SpriteRenderer>();
        nextImage.sprite = nextRenderer.sprite;
    }

    public void ChooseNextDango()
    {
        //�_���S����������邽�т�UI�̃_���S�����ւ��鏈��
        nextDango = secondDango.secondDango;

        secondDango.ChooseSecondDango();

        nextRenderer = nextDango.GetComponent<SpriteRenderer>();
        nextImage.sprite = nextRenderer.sprite;
    }

}
