using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proceed : MonoBehaviour
{
    public PlayerMove pauseFlag;
    public GameObject PausePanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Proceeds()
    {
        pauseFlag.pauseFlag = false;
        PausePanel.SetActive(false);
        Time.timeScale = 1;
    }
}