using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestTime2 : MonoBehaviour
{
    public float bestTime2;
    public string key2 = "BestTime2";
    [SerializeField] TextMeshProUGUI bestTimerText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bestTime2 = PlayerPrefs.GetFloat(key2, 100.00f);
        bestTimerText.text = "Best Time : " + bestTime2.ToString("F2");
    }
}