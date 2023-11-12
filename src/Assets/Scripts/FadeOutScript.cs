using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeOutScript : MonoBehaviour
{


    public GameObject Panelfade;   //�t�F�[�h�p�l���̎擾

    Image fadealpha;               //�t�F�[�h�p�l���̃C���[�W�擾�ϐ�

    private float alpha;           //�p�l����alpha�l�擾�ϐ�

    private bool fadeout;          //�t�F�[�h�A�E�g�̃t���O�ϐ�


    // Use this for initialization
    void Start()
    {
        fadealpha = Panelfade.GetComponent<Image>(); //�p�l���̃C���[�W�擾
        alpha = fadealpha.color.a;                 //�p�l����alpha�l���擾
        fadeout = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            // �J�[�\����\��
            Cursor.visible = false;

            fadeout = true;
        }

        if (fadeout)
            FadeOut();

        if (alpha >= 1)
        {
            SceneManager.LoadScene("Menu");
            
        }
    }

    public void FadeOut()
    {
        alpha += 0.001f;
        fadealpha.color = new Color(0, 0, 0, alpha);
        if (alpha >= 1)
        {
            fadeout = false;
        }
    }
}