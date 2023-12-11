using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HowToPlay : MonoBehaviour
{
    public FadeOutScript Fadeoutscript;
    private Image ruleimage;
    public Sprite[] rulesprite;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        ruleimage = GetComponent<Image>();
        ruleimage.sprite = rulesprite[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("joystick button 0"))
            TapDownUI();
    }
    public void TapDownUI()
    {
        switch (count)
        {
            case 0:
                ruleimage.sprite = rulesprite[1];//2–‡–Ú‚Ìƒ‹[ƒ‹Ğ‰î‰æ–Ê‚Ö
                count++;
                break;
            case 1:
                ruleimage.sprite = rulesprite[2];//3–‡–Ú‚Ìƒ‹[ƒ‹Ğ‰î‰æ–Ê‚Ö
                count++;
                break;
            case 2:
                SceneManager.LoadScene("Menu");
                break;

        }
    }
}