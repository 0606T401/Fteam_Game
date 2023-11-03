using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    Button GameStart;
    Button HowToPlay;
    Button Settings;

    // Start is called before the first frame update
    void Start()
    {
        GameStart = GameObject.Find("/Canvas/GameStart").GetComponent<Button>();
        HowToPlay = GameObject.Find("/Canvas/HowtoPlay").GetComponent <Button>();
        Settings = GameObject.Find("/Canvas/Settings").GetComponent <Button> ();

        GameStart.Select();
    }

    void Update()
    {

    }
}