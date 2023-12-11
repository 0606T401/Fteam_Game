using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountUpTimer2 : MonoBehaviour
{
    private StartTimer timer;
    public float CountUpTime = 0f;
    public TextMeshProUGUI time;
    public GoalCheck goal;
    public Data data;
    public bool end;

    private float countTime;
    public float bestTime2;
    public string key2 = "BestTime";
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] TextMeshProUGUI bestTimerText;

    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find("Timer").GetComponent<StartTimer>();

        //PlayerPrefs.DeleteAll();
        bestTime2 = PlayerPrefs.GetFloat(key2, 100);
        bestTimerText.text = "Best Time : " + bestTime2.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.CountDownTime < 0)
        {

            if (!end)
            {
                time.text = string.Format("{0:0.00}", CountUpTime);
                CountUpTime += Time.deltaTime;
                countTime += Time.deltaTime;
                timerText.text = countTime.ToString("F2");
            }

        }
        if (goal.goal || data.Hit)
        {
            //Time.timeScale = 0;
            end = true;
            if (goal.goal)
            {
                if (CountUpTime < bestTime2)//ベストタイムを更新
                {
                    bestTime2 = CountUpTime;
                    PlayerPrefs.SetFloat(key2, bestTime2);
                    bestTimerText.text = "Best Time : " + bestTime2.ToString("F2");
                    PlayerPrefs.Save();
                }
            }
        }
    }
}
