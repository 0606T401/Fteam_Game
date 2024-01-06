using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeOutSS : MonoBehaviour
{
    public GameObject Panelfade;   //フェードパネルの取得

    Image fadealpha;               //フェードパネルのイメージ取得変数

    private float alpha;           //パネルのalpha値取得変数

    private bool fadeout;          //フェードアウトのフラグ変数

    // Start is called before the first frame update
    void Start()
    {
        fadealpha = Panelfade.GetComponent<Image>(); //パネルのイメージ取得
        alpha = fadealpha.color.a;                 //パネルのalpha値を取得
        Panelfade.SetActive(false);
        fadeout = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (fadeout)
            FadeOut();

        if (alpha >= 1)
        {
            SceneManager.LoadScene("StageSelect");

        }
    }

    public void GameMenu()
    {
        Panelfade.SetActive(true);
        fadeout = true;
    }

    void FadeOut()
    {
        alpha += 0.01f;
        fadealpha.color = new Color(0, 0, 0, alpha);
        if (alpha >= 1)
        {
            fadeout = false;
        }
    }
}
