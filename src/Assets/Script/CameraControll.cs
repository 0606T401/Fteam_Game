using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CameraControll : MonoBehaviour
{

    [SerializeField] GameObject mainCamera;      //メインカメラ格納用
    [SerializeField] GameObject FPCamera;       //サブカメラ格納用 
    bool FPcamera = false;
    bool BbuttonFlag = false;

    //呼び出し時に実行される関数
    void Start()
    {
        FPCamera.SetActive(false);
    }


    //単位時間ごとに実行される関数
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
            //メインカメラをアクティブに設定
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