using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirdDango : MonoBehaviour
{
    //���̃I�u�W�F�N�g��Image�R���|�[�l���g������ϐ�
    private Image thirdImage;

    //DangoLottery�N���X�̎擾
    [SerializeField] private GameObject dangoLotteryObj;
    private DangoLottery dangoLottery;

    //���I���ʂ̃_���S�I�u�W�F�N�g������ϐ�
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
