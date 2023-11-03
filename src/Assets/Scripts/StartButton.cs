using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void Start()
    {
        if (Input.anyKey)
        SceneManager.LoadScene("Menu");
    }
}
