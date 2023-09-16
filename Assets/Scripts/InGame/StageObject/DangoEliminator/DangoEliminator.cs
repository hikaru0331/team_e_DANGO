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

    //���p�[�e�B�N���̎擾
    [SerializeField] private GameObject smokeParticle;

    //�^�k�L�o��܂ł̎��Ԃ�ݒ肷�邽�߂̕ϐ�
    private float timer;
    private float raccoonInterval;

    private SoundManager soundManager;

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
        raccoonInterval = Random.Range(45.0f, 120.0f);

        soundManager = SoundManager.Instance;
    }

    //�^�k�L���A�N�e�B�u�ɂ��郁�\�b�h
    private void RaccoonSet()
    {
        soundManager.seManager.PlayOneShot(soundManager.raccoon);

        dustBox.gameObject.SetActive(false);
        raccoon.gameObject.SetActive(true);

        //���p�[�e�B�N���̐����E�j��
        GameObject smokeParticleClone = Instantiate(smokeParticle, this.gameObject.transform.position, Quaternion.identity);
        Destroy(smokeParticleClone, 2.0f);
    }

    //�S�~�����A�N�e�B�u�ɂ��郁�\�b�h
    public void DustBoxSet()
    {
        soundManager.seManager.PlayOneShot(soundManager.raccoon);

        raccoon.gameObject.SetActive(false);
        dustBox.gameObject.SetActive(true);

        //���p�[�e�B�N���̐����E�j��
        GameObject smokeParticleClone = Instantiate(smokeParticle, this.gameObject.transform.position, Quaternion.identity);
        Destroy(smokeParticleClone, 2.0f);

        //�^�k�L�����܂ł̎��Ԃ������_���Ō���
        raccoonInterval = Random.Range(45.0f, 120.0f);
        timer = 0;
    }

    //Tween���ꎞ��~����R���[�`��
    public IEnumerator PauseTween(float pauseTime)
    {
        eliminatorTransform.DOPause();

        yield return new WaitForSeconds(pauseTime);

        eliminatorTransform.DOPlay();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= raccoonInterval)
        {
            //�^�k�L�̃I�u�W�F�N�g����A�N�e�B�u�̎��Ɏ��s����
            if (!raccoon.gameObject.activeInHierarchy)
            {
                RaccoonSet();
                timer = 0;
            }                    
        }
    }
}
