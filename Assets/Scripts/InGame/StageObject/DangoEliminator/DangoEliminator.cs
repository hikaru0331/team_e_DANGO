using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DangoEliminator : MonoBehaviour
{
    //DangoEliminator��Transform������ϐ�
    private Transform eliminatorTransform;

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
