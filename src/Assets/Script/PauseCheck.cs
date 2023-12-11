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

    public float beforeTimeS = 1;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (pauseFlag.pauseFlag)
        {
            if (GameOver.activeSelf == false || ClearPanel.activeSelf == false)
            {
                beforeTimeS = Time.timeScale;
                Time.timeScale = 0;
                EventSystem.current.SetSelectedGameObject(null);
                EventSystem.current.SetSelectedGameObject(PauseFirstbutton);
                PausePanel.SetActive(true);
            }
        }
    }
}
