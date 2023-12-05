using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestTime1 : MonoBehaviour
{
    public CountUpTimer countUpTimer;
    public string key = "BestTime";
    [SerializeField] TextMeshProUGUI bestTimerText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        countUpTimer.bestTime = PlayerPrefs.GetFloat(key, 100);
        bestTimerText.text = "Best Time : " + countUpTimer.bestTime.ToString("F2");
    }
}