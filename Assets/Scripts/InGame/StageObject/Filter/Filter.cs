using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Filter : MonoBehaviour
{
    private Transform parentTransform;

    // Start is called before the first frame update
    void Start()
    {
        parentTransform = transform.parent.GetComponent<Transform>();

        parentTransform.DOLocalMoveX(3.5f, 3.0f)
           .SetEase(Ease.InOutQuad)
           .SetLoops(-1, LoopType.Yoyo);
    }

    protected virtual void ChangeDangoColor()
    {

    }

}
