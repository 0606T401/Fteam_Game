using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestTime3 : MonoBehaviour
{
    public float bestTime3;
    public string key3 = "BestTime";
    [SerializeField] TextMeshProUGUI bestTimerText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //countUpTimer.bestTime = PlayerPrefs.GetFloat(key, 100);
        bestTime3 = PlayerPrefs.GetFloat(key3, 100.00f);
        bestTimerText.text = "Best Time : " + bestTime3.ToString("F2");
    }
}