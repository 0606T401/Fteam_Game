using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeInScript : MonoBehaviour
{


    public GameObject Panelfade;   //�t�F�[�h�p�l���̎擾

    Image fadealpha;               //�t�F�[�h�p�l���̃C���[�W�擾�ϐ�

    private float alpha;           //�p�l����alpha�l�擾�ϐ�

    public bool fadein;          //�t�F�[�h�A�E�g�̃t���O�ϐ�

    // Use this for initialization
    void Start()
    {
        fadealpha = Panelfade.GetComponent<Image>(); //�p�l���̃C���[�W�擾
        alpha = fadealpha.color.a;                 //�p�l����alpha�l���擾
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