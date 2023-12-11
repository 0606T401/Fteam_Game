using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestTime1 : MonoBehaviour
{
    public float bestTime1;
    public string key1 = "BestTime";
    [SerializeField] TextMeshProUGUI bestTimerText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //countUpTimer.bestTime = PlayerPrefs.GetFloat(key, 100);
        bestTime1 = PlayerPrefs.GetFloat(key1, 100.00f);
        bestTimerText.text = "Best Time : " + bestTime1.ToString("F2");
    }
}