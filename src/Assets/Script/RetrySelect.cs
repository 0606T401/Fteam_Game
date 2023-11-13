using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RetrySelect : MonoBehaviour
{
    Button Retry;
    Button StageSelect;

    // Start is called before the first frame update
    void Start()
    {
        Retry = GameObject.Find("/Canvas/GameOver/RetryButton").GetComponent<Button>();
        StageSelect = GameObject.Find("/Canvas/GameOver/StageSelectButton").GetComponent<Button>();

        Retry.Select();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
