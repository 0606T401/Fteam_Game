using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PauseCheck : MonoBehaviour
{
    [SerializeField] GameObject Player;

    public GameObject GameOver;
    public GameObject ClearPanel;
    public GameObject PausePanel;

    public PlayerMove pauseFlag;
    public Data data;

    public GameObject PauseFirstbutton;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pauseFlag.pauseFlag)
        {
            data.fallspeed = 0f;
            if (GameOver.activeSelf == false || ClearPanel.activeSelf == false)
            {
                EventSystem.current.SetSelectedGameObject(null);
                EventSystem.current.SetSelectedGameObject(PauseFirstbutton);
                PausePanel.SetActive(true);
            }
        }
    }
}
