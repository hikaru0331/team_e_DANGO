using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DangoEliminator : MonoBehaviour
{
    //DangoEliminator��Transform������ϐ�
    private Transform eliminatorTransform;

    //�q�I�u�W�F�N�g�̃S�~���ƃ^�k�L���Q�Ƃ��邽�߂̕ϐ�
    [SerializeField] private GameObject dustBox;
    [SerializeField] private GameObject raccoon;

    [SerializeField] private GameObject smokeParticle;

    //�^�k�L�o��܂ł̎��Ԃ�ݒ肷�邽�߂̕ϐ�
    private float timer;
    private float raccoonInterval;

    // Start is called before the first frame update
    void Start()
    {
        //Transform���擾
        eliminatorTransform = this.gameObject.GetComponent<Transform>();
        
        //�I�u�W�F�N�g�Ɛ��Ώۂ̈ʒu����
        //�I�u�W�F�N�g�̃X�^�[�g�ʒu���E�[�ƍ��[�̂ǂ���ł����������������邽��
        float moveDistination = -eliminatorTransform.position.x;

        //�I�u�W�F�N�g�̈ړ��𐧌�
        eliminatorTransform.DOLocalMoveX(moveDistination, 10.0f)
           .SetEase(Ease.InOutQuad)
           .SetLoops(-1, LoopType.Yoyo);

        //�^�k�L�����܂ł̎��Ԃ������_���Ō���
        raccoonInterval = Random.Range(5.0f, 5.0f);
    }

    private void RaccoonSetter()
    {
        dustBox.gameObject.SetActive(false);
        raccoon.gameObject.SetActive(true);

        GameObject smokeParticleClone = Instantiate(smokeParticle, this.gameObject.transform.position, Quaternion.identity);
        Destroy(smokeParticleClone, 2.0f);
    }

    public void DustBoxSetter()
    {
        raccoon.gameObject.SetActive(false);
        dustBox.gameObject.SetActive(true);

        GameObject smokeParticleClone = Instantiate(smokeParticle, this.gameObject.transform.position, Quaternion.identity);
        Destroy(smokeParticleClone, 2.0f);

        //�^�k�L�����܂ł̎��Ԃ������_���Ō���
        raccoonInterval = Random.Range(45.0f, 120.0f);
    }

    //Tween���ꎞ��~����R���[�`����������ւ�ɏ���

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= raccoonInterval)
        {
            //�^�k�L�̃I�u�W�F�N�g����A�N�e�B�u�̎��Ɏ��s����
            if (!raccoon.gameObject.activeInHierarchy)
            {
                RaccoonSetter();
                timer = 0;
            }                    
        }
    }
}
