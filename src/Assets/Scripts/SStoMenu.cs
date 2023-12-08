using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SStoMenu : MonoBehaviour
{
    public GameObject Panelfade;   //フェードパネルの取得

    Image fadealpha;               //フェードパネルのイメージ取得変数

    private float alpha;           //パネルのalpha値取得変数

    private bool fadeout;          //フェードアウトのフラグ変数

    public float fadespeed = 0.1f;

    public AudioClip cancel;
    AudioSource audioSource;
    // Use this for initialization
    void Start()
    {
        fadealpha = Panelfade.GetComponent<Image>(); //パネルのイメージ取得
        alpha = fadealpha.color.a;                 //パネルのalpha値を取得
        Panelfade.SetActive(false);
        fadeout = false;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown("joystick button 1"))
        {
            audioSource.PlayOneShot(cancel);
            Panelfade.SetActive(true);
            fadeout = true;
        }

        if (fadeout)
            FadeOut();

        if (alpha >= 1)
        {
            //audioSource.PlayOneShot(cancel);

            SceneManager.LoadScene("Menu");

            // カーソル表示
            Cursor.visible = true;

        }
    }

    public void GameStart()
    {
        Panelfade.SetActive(true);
        fadeout = true;
    }

    void FadeOut()
    {
        alpha += fadespeed;
        fadealpha.color = new Color(0, 0, 0, alpha);
        if (alpha >= 1)
        {
            fadeout = false;
        }
    }
}