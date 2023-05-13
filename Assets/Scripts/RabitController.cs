using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabitController : MonoBehaviour
{
    //���̃I�u�W�F�N�g������ϐ��ƈړ����x�̕ϐ�
    public GameObject rabit;
    public float moveSpeed;

    //�c�q�����ꏊ�̃Q�[���I�u�W�F�N�g������ϐ�
    public GameObject generatePosition;

    //�c�q�����ɂ������ϐ�
    public GameObject dango;
    private float timer;
    public float interval;

    //�A�j���[�V�����Ɋւ���ϐ�
    private SpriteRenderer rabitSprite;
    [SerializeField] private Sprite idleSprite;
    [SerializeField] private Sprite shotSprite;

    // Start is called before the first frame update
    void Start()
    {
        rabitSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= interval)
        {
            timer = 0;

            rabitSprite.sprite = shotSprite;
            Instantiate(dango, generatePosition.gameObject.transform.position, Quaternion.identity);

            Invoke("SpriteResetter", 0.2f);
        }
    }

    //�E�T�M�̉摜�����Ƃɖ߂��֐�
    private void SpriteResetter()
    {
        rabitSprite.sprite = idleSprite;
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 10)
        {
            rabit.transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -10)
        {
            rabit.transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
    }
}
