using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBGM : MonoBehaviour
{

    public bool DontDestroyEnabled = true;

    bool SceneMove = false;

    public AudioClip BGM;
    AudioSource audioSource;
    bool AbuttonFlag = false;
    // Use this for initialization
    void Start()
    {
        if (DontDestroyEnabled)
        {
            // Sceneを遷移してもオブジェクトが消えないようにする
            //DontDestroyOnLoad(this);
            audioSource = GetComponent<AudioSource>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("joystick button 0") == true && !SceneMove&& !AbuttonFlag)
        {
            Debug.Log("Dont Destroy A");
            DontDestroyOnLoad(this);
            AbuttonFlag = true;
            SceneMove = true;
        }
        if (Input.GetKeyDown("joystick button 1")==true && SceneMove)
        {
            audioSource.Pause();
            Debug.Log("Destroy B");
        }
        if (Input.GetKeyDown("joystick button 0") == true && SceneMove && !AbuttonFlag)
        {
            audioSource.Pause();
            Debug.Log("Destroy A");
            AbuttonFlag = true;
        }
        if (Input.GetButton("joystick button 0") == false && AbuttonFlag == true)
        {
            Debug.Log("FlagCancel");
            AbuttonFlag = false;
        }
    }

    

}
