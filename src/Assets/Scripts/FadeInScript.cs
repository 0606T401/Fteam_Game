using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeInScript : MonoBehaviour
{


    public GameObject Panelfade;   //フェードパネルの取得

    Image fadealpha;               //フェードパネルのイメージ取得変数

    private float alpha;           //パネルのalpha値取得変数

    public bool fadein;          //フェードアウトのフラグ変数

    // Use this for initialization
    void Start()
    {
        fadealpha = Panelfade.GetComponent<Image>(); //パネルのイメージ取得
        alpha = fadealpha.color.a;                 //パネルのalpha値を取得
        fadein = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (fadein)
            FadeIn();
    }

    void FadeIn()
    {
        alpha -= 0.001f;
        fadealpha.color = new Color(0, 0, 0, alpha);
        if (alpha <= 0)
        {
            fadein = false;
            Destroy(Panelfade);
        }
    }
}