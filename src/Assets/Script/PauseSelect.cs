using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseSelect : MonoBehaviour
{
    Button Retry;
    Button StageSelect;
    Button Pause;

    // Start is called before the first frame update
    void Start()
    {
        Retry = GameObject.Find("/Canvas/PausePanel/RetryButtonPause").GetComponent<Button>();
        StageSelect = GameObject.Find("/Canvas/PausePanel/StageSelectButtonPause").GetComponent<Button>();
        Pause = GameObject.Find("/Canvas/PausePanel/ProceedButton").GetComponent<Button>();

        Pause.Select();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
