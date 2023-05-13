using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabitController : MonoBehaviour
{
    //このオブジェクトを入れる変数と移動速度の変数
    public GameObject rabit;
    public float moveSpeed;

    //団子生成場所のゲームオブジェクトを入れる変数
    public GameObject generatePosition;

    //団子生成にかかわる変数
    public GameObject dango;
    private float timer;
    public float interval;

    //アニメーションに関する変数
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

    //ウサギの画像をもとに戻す関数
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
