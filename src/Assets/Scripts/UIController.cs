using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject Text;

    // Update is called once per frame
    public void ActiveStart()
    {
        Text.SetActive(true);
    }

    public void Update()
    {
        Invoke(nameof(ActiveStart), 1.0f);
    }
}
