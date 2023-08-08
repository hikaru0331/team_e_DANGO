using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangoLottery : MonoBehaviour
{
    private Dictionary<GameObject, float> probability;
    public GameObject[] dangos;

    private void Awake()
    {
        InitializeDictionary();
    }

    public GameObject ChooseDango()
    {
        // �m���̍��v�l���i�[
        float total = 0;

        // �G�h���b�v�p�̎�������h���b�v�������v����
        foreach (KeyValuePair<GameObject, float> elem in probability)
        {
            total += elem.Value;
        }

        // Random.value�ł�0����1�܂ł�float�l��Ԃ��̂�
        // �����Ƀh���b�v���̍��v���|����
        float randomPoint = Random.value * total;

        // randomPoint�̈ʒu�ɊY������L�[��Ԃ�
        foreach (KeyValuePair<GameObject, float> elem in probability)
        {
            if (randomPoint < elem.Value)
            {
                return elem.Key;
            }
            else
            {
                randomPoint -= elem.Value;
            }
        }
        return null;
    }

    //�ʏ��Ԃ̔����m���������ɒ�`
    public void InitializeDictionary()
    {
        probability = new Dictionary<GameObject, float>();
        probability.Add(dangos[0], 20.0f);
        probability.Add(dangos[1], 3.3f);
        probability.Add(dangos[2], 10.0f);

        probability.Add(dangos[3], 20.0f);
        probability.Add(dangos[4], 3.3f);
        probability.Add(dangos[5], 10.0f);

        probability.Add(dangos[6], 20.0f);
        probability.Add(dangos[7], 3.3f);
        probability.Add(dangos[8], 10.0f);
    }

    //�t�B�[�o�[��Ԃ̔����m���������ɒ�`
    public void FeverDictionary()
    {
        probability = new Dictionary<GameObject, float>();
        probability.Add(dangos[0], 0.0f);
        probability.Add(dangos[1], 0.0f);
        probability.Add(dangos[2], 33.3f);

        probability.Add(dangos[3], 0.0f);
        probability.Add(dangos[4], 0.0f);
        probability.Add(dangos[5], 33.3f);
            
        probability.Add(dangos[6], 0.0f);
        probability.Add(dangos[7], 0.0f);
        probability.Add(dangos[8], 33.3f);
    }
}