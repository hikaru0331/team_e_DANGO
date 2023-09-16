using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondDango : MonoBehaviour
{
    //���̃I�u�W�F�N�g��Image�R���|�[�l���g������ϐ�
    private Image secondImage;

    //DangoLottery�N���X�̎擾
    [SerializeField] private GameObject dangoLotteryObj;
    private DangoLottery dangoLottery;

    //ThirdDango�N���X�̎擾
    [SerializeField] private GameObject thirdDangoObj;
    private ThirdDango thirdDango;

    //ThirdDango���瓾���_���S�I�u�W�F�N�g������ϐ�
    [System.NonSerialized] public GameObject secondDango;
    private SpriteRenderer secondRenderer;

    // Start is called before the first frame update
    void Start()
    {
        //�R���|�[�l���g�̎擾
        secondImage = this.GetComponent<Image>();
        dangoLottery = dangoLotteryObj.GetComponent<DangoLottery>();

        thirdDango = thirdDangoObj.GetComponent<ThirdDango>();

        //�Q�[���J�n����UI�ɕ\������_���S�����߂鏈��
        secondDango = dangoLottery.ChooseDango();
        secondRenderer = secondDango.GetComponent<SpriteRenderer>();
        secondImage.sprite = secondRenderer.sprite;
    }

    public void ChooseSecondDango()
    {
        //�_���S����������邽�т�UI�̃_���S�����ւ��鏈��
        secondDango = thirdDango.thirdDango;

        thirdDango.ChooseThirdDango();

        secondRenderer = secondDango.GetComponent<SpriteRenderer>();
        secondImage.sprite = secondRenderer.sprite;
    }

}
