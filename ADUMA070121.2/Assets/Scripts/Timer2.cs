using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer2 : MonoBehaviour
{
    Image timerBar;
    public float maxTime = 5f;
    float timeLeft;
    public GameObject timesUpText;
    public TextMeshProUGUI wordCountText;
    public GameObject retryButton;
    public Typer typer;
    public static bool boo_stop;

    void Start()
    {
        timesUpText.SetActive(false);
        retryButton.gameObject.SetActive(false);
        wordCountText.gameObject.SetActive(false);
        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
    }
    void Update()
    {
        if (!boo_stop)
        {
            if (timeLeft >= 0)
            {
                timeLeft -= Time.deltaTime;
                timerBar.fillAmount = timeLeft / maxTime;

            }
            else
            {
                timesUpText.SetActive(true);
                Typer2.boo_gameOver = true;
                wordCountText.text = "Words left: " + typer.int_wordCount;
                wordCountText.gameObject.SetActive(true);
                Time.timeScale = 0;
                retryButton.gameObject.SetActive(true);
            }
        }
    }
    public void fn_time(bool _boo_add)
    {
        timeLeft += _boo_add ? 1f : -2f;

    }
}
