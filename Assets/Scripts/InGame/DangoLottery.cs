using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangoLottery : MonoBehaviour
{
    //�F�̖��O�Əd�݂����鎫���^�ϐ�
    public Dictionary<string, float> colorList;
    //�F�̒��I�Ɏg���d�݂̑��a
    private float colorTotalWeight;

    //�����̖��O�Əd�݂����鎫���^�ϐ�
    public Dictionary<string, float> attributeList;

    // Start is called before the first frame update
    void Start()
    {
        InitializeDicts();
        ColorWeightCalculator();
    }

    //�e�����̏�����
    private void InitializeDicts()
    {
        colorList = new Dictionary<string, float>
        {
            { "green", 1.0f },
            { "red", 1.0f },
            { "white", 1.0f }
        };

        attributeList = new Dictionary<string, float>
        {
            { "normal", 5.0f },
            { "poison", 2.0f },
            { "rabit", 3.0f }
        };
    }

    //�F�̒��I�ɂ�����d�݂̑��a�v�Z
    public void ColorWeightCalculator()
    {
        // �d�݂̑��a�v�Z
        foreach (float value in colorList.Values)
        {
            colorTotalWeight += value;
        }
    }

    public string ChooseColor()
    {
        // 0�`�d�݂̑��a�͈̗̔͂����l�擾
        float randomPoint = Random.Range(0.0f, colorTotalWeight);

        // �����l��������v�f��擪���珇�ɑI��
        var currentWeight = 0f;

        foreach (var value in colorList)
        {
            currentWeight += value.Value;

            // �����l�����ݗv�f�͈͓̔����`�F�b�N
            if (randomPoint < currentWeight)
            {
                return value.Key;
            }
        }

        // �����l���d�݂̑��a�ȏ�Ȃ疖���v�f�Ƃ���
        return "colorList.Count - 1";
    }

    // Update is called once per frame
    private void Update()
    {
        // �X�y�[�X�L�[�������Ă���ԁA�I��v�f���o�͂�������
        if (Input.GetKey(KeyCode.Space))
        {
            var index = ChooseColor();
            Debug.Log($"���I���ꂽ�v�f : {index}");
        }
    }
}
