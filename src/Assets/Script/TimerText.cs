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
        //�x�X�g�^�C����\��
        bestTimerText.text = bestTime.ToString("F2");

        //�^�C�}�[�쓮
        if (!isStop)
        {
            countUpTime = 0;
            bestTime = PlayerPrefs.GetFloat("TIME", 100);
            countUpTime += Time.deltaTime;
            timerText.text = countUpTime.ToString("F2");
        }

        //���N���b�N�Ń^�C�}�[��~
        if (Input.GetMouseButtonDown(0))
        {
            isStop = true;
            if (countUpTime < bestTime)//�x�X�g�^�C�����X�V
            {
                bestTime = countUpTime;
                PlayerPrefs.SetFloat("TIME", bestTime);
                PlayerPrefs.Save();
            }
        }
    }
}
