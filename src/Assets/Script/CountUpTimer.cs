using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountUpTimer : MonoBehaviour
{
    private StartTimer timer;
    public float CountUpTime = 0f;
    public TextMeshProUGUI time;
    public GoalFlag goal;
    public Data data;

    private float countTime;
    public float bestTime1;
    public string key = "BestTime";
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] TextMeshProUGUI bestTimerText;

    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find("Timer").GetComponent<StartTimer>();

        PlayerPrefs.DeleteAll();
        bestTime1 = PlayerPrefs.GetFloat(key, 100);
        bestTimerText.text = "Best Time : " + bestTime1.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.CountDownTime < 0)
        {
            time.text = string.Format("{0:0.00}", CountUpTime);
            CountUpTime += Time.deltaTime;

            countTime += Time.deltaTime;
            timerText.text = countTime.ToString("F2");
        }
        if (goal.Goal || data.Hit)
        {
            Time.timeScale = 0;
            if (goal.Goal)
            {
                if (CountUpTime < bestTime1)//ベストタイムを更新
                {
                    bestTime1 = CountUpTime;
                    PlayerPrefs.SetFloat(key, bestTime1);
                    bestTimerText.text = "Best Time : " + bestTime1.ToString("F2");
                    PlayerPrefs.Save();
                }
            }
        }
    }
}
