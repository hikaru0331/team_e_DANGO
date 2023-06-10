using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Image image1;
    public Image image2;
    public Image image3;
    Image1Replace a;
    Image2Replace b;
    Image3Replace c;
    bool flag1 = true;
    bool flag2 = true;
    bool flag3 = true;

    // Start is called before the first frame update
    void Start()
    {
        // image非表示
        image1.enabled = false;
        image2.enabled = false;
        image3.enabled = false;

        a = GetComponentInChildren<Image1Replace>();
        b = GetComponentInChildren<Image2Replace>();
        c = GetComponentInChildren<Image3Replace>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!flag3) {


            image1.enabled = false;
            image2.enabled = false;
            image3.enabled = false;

            flag1 = true;
            flag2 = true;
            flag3 = true;
        }
    }

    private async void OnCollisionEnter2D(Collision2D other)
    {
        // 最初の衝突時の処理
        if (flag1)
        {
            // image1に団子表示
            if (other.gameObject.name == "dangoG(Clone)" )
            {
                image1.enabled = true;
                a.image1ToG();
            }
            else if (other.gameObject.name == "dangoR(Clone)" )
            {
                image1.enabled = true;
                a.image1ToR();
            }
            else if (other.gameObject.name == "dangoW(Clone)" )
            {
                image1.enabled = true;
                a.image1ToW();
            }

            flag1 = false;
        }
        // 2回目の衝突時の処理
        else if (flag2)
        {
            // image2に団子表示
            if (other.gameObject.name == "dangoG(Clone)" )
            {
                image2.enabled = true;
                b.image2ToG();
            }
            else if (other.gameObject.name == "dangoR(Clone)" )
            {
                image2.enabled = true;
                b.image2ToR();
            }
            else if (other.gameObject.name == "dangoW(Clone)" )
            {
                image2.enabled = true;
                b.image2ToW();
            }

            flag2 = false;
        }
        // 3回目の衝突時の処理
        else if (flag3)
        {
            // image3に団子表示
            if (other.gameObject.name == "dangoG(Clone)" )
            {
                image3.enabled = true;
                c.image3ToG();
            }
            else if (other.gameObject.name == "dangoR(Clone)" )
            {
                image3.enabled = true;
                c.image3ToR();
            }
            else if (other.gameObject.name == "dangoW(Clone)" )
            {
                image3.enabled = true;
                c.image3ToW();
            }

            await Task.Delay(500);
            
            flag3 = false;
        }

        Destroy(other.gameObject);
        Debug.Log("Goal!!");
    }
}
