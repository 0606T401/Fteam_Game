using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerText : MonoBehaviour
{
    private float countUpTime;
    private float bestTime;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] TextMeshProUGUI bestTimerText;

    public float CountDownTime = 3f;
    public TextMeshProUGUI CountDownTimer;

    private bool isStop;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //ベストタイムを表示
        bestTimerText.text = bestTime.ToString("F2");

        //タイマー作動
        if (!isStop)
        {
            countUpTime = 0;
            bestTime = PlayerPrefs.GetFloat("TIME", 100);
            countUpTime += Time.deltaTime;
            timerText.text = countUpTime.ToString("F2");
        }

        //左クリックでタイマー停止
        if (Input.GetMouseButtonDown(0))
        {
            isStop = true;
            if (countUpTime < bestTime)//ベストタイムを更新
            {
                bestTime = countUpTime;
                PlayerPrefs.SetFloat("TIME", bestTime);
                PlayerPrefs.Save();
            }
        }
    }
}
