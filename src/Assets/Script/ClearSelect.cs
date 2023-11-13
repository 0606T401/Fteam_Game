using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearSelect : MonoBehaviour
{
    Button RetryButton;
    Button StageSelectButton;

    // Start is called before the first frame update
    void Start()
    {

        RetryButton = GameObject.Find("/Canvas/ClearPanel/RetryButton").GetComponent<Button>();
        StageSelectButton = GameObject.Find("/Canvas/ClearPanel/StageSelectButton").GetComponent<Button>();

        RetryButton.Select();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
