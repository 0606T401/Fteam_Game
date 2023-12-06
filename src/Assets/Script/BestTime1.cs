using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestTime1 : MonoBehaviour
{
    public float bestTime;
    public string key = "BestTime";
    [SerializeField] TextMeshProUGUI bestTimerText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //countUpTimer.bestTime = PlayerPrefs.GetFloat(key, 100);
        bestTime = PlayerPrefs.GetFloat(key, 100.00f);
        bestTimerText.text = "Best Time : " + bestTime.ToString("F2");
    }
}