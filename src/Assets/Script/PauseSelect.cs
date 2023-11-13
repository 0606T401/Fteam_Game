using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseSelect : MonoBehaviour
{
    Button proceed;
    Button back_to_title;
    // Start is called before the first frame update
    void Start()
    {
        proceed = GameObject.Find("/Canvas/Pause/proceedButton").GetComponent<Button>();
        back_to_title = GameObject.Find("/Canvas/Pause/back_to_titleButton").GetComponent<Button>();
        proceed.Select();
    }
    // Update is called once per frame
    void Update()
    {

    }
}