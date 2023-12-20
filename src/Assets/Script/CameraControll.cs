using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CameraControll : MonoBehaviour
{

    [SerializeField] GameObject mainCamera;      //���C���J�����i�[�p
    [SerializeField] GameObject FPCamera;       //�T�u�J�����i�[�p 
    bool FPcamera = false;
    bool BbuttonFlag = false;

    //�Ăяo�����Ɏ��s�����֐�
    void Start()
    {
        FPCamera.SetActive(false);
    }


    //�P�ʎ��Ԃ��ƂɎ��s�����֐�
    void Update()
    {
        
        if (Input.GetButton("Bbutton") && !FPcamera && !BbuttonFlag )
        {
            Debug.Log("FPCamera");
            mainCamera.SetActive(false);
            FPCamera.SetActive(true);
            BbuttonFlag = true;
            FPcamera = true;
        }
        if (Input.GetButton("Bbutton") && FPcamera && !BbuttonFlag)
        {
            Debug.Log("mainCamera");
            //���C���J�������A�N�e�B�u�ɐݒ�
            FPCamera.SetActive(false);
            mainCamera.SetActive(true);
            BbuttonFlag = true;
            FPcamera = false;
        }
        if (Input.GetButton("Bbutton") == false && BbuttonFlag)
        {
            Debug.Log("FlagCancel");
            BbuttonFlag = false;
        }
    }
}