using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelectButton : MonoBehaviour
{
    Button Stage1;
    Button Stage2;
    Button Stage3;

    // Start is called before the first frame update
    void Start()
    {
        Stage1 = GameObject.Find("/Canvas/Stage1").GetComponent<Button>();
        Stage2 = GameObject.Find("/Canvas/Stage2").GetComponent<Button>();
        Stage3 = GameObject.Find("/Canvas/Stage3").GetComponent<Button>();

        Stage1.Select();
    }

    void Update()
    {

    }
}