using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pause : MonoBehaviour
{
    public GameObject ContinueButton, BackTitleButton;

    [SerializeField] private GameObject pauseUI;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 0f)
        {
            pauseUI.SetActive(true);


            EventSystem.current.SetSelectedGameObject(null);

            EventSystem.current.SetSelectedGameObject(ContinueButton);
        }
    }
}
