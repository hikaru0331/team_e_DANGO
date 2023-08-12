using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirdDango : MonoBehaviour
{
    //���̃I�u�W�F�N�g��Image�R���|�[�l���g������ϐ�
    private Image thirdImage;

    //DangoLottery�N���X������ϐ�
    [SerializeField] private GameObject dangoLotteryObj;
    private DangoLottery dangoLottery;

    //���I���ʂ̃_���S�I�u�W�F�N�g������ϐ�
    [System.NonSerialized] public GameObject thirdDango;
    private SpriteRenderer thirdRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        //�R���|�[�l���g�̎擾
        thirdImage = this.GetComponent<Image>();
        dangoLottery = dangoLotteryObj.GetComponent<DangoLottery>();

        //�Q�[���J�n����UI�ɕ\������_���S�����߂鏈��
        thirdDango = dangoLottery.ChooseDango();
        thirdRenderer = thirdDango.GetComponent<SpriteRenderer>();
        thirdImage.sprite = thirdRenderer.sprite;
    }

    public void ChooseThirdDango()
    {
        //�_���S����������邽�т�UI�̃_���S�����ւ��鏈��
        thirdDango = dangoLottery.ChooseDango();
        thirdRenderer = thirdDango.GetComponent<SpriteRenderer>();
        thirdImage.sprite = thirdRenderer.sprite;
    }

}
