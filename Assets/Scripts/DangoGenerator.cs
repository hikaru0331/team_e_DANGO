using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangoGenerator : MonoBehaviour
{
    //�c�q�����ꏊ�̃Q�[���I�u�W�F�N�g������ϐ�
    public GameObject generatePosition;

    //�c�q�����ɂ������ϐ�
    public GameObject dango;
    private float timer;
    public float interval;

    //RabitAnimator�N���X�̎擾
    RabitAnimator rabitAnimator;

    // Start is called before the first frame update
    void Start()
    {
        rabitAnimator = GetComponent<RabitAnimator>();
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if (timer >= interval)
        {
            timer = 0;

            //rabitSprite.sprite = shotSprite;
            Instantiate(dango, generatePosition.gameObject.transform.position, Quaternion.identity);

            Invoke("SpriteResetter", 0.2f);
        }
    }
}
