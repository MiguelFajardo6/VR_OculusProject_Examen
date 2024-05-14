using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text timerText;

    [SerializeField] private float timeElapsed;
    private int minutes, seconds, cents;
    private bool end = false;

    void Update()
    {
        if (!end){ 
            timeElapsed -= Time.deltaTime;

            if (timeElapsed < 0) timeElapsed = 0;

            minutes = (int)(timeElapsed / 60f);
            seconds = (int)(timeElapsed - minutes * 60f);
            cents = (int)((timeElapsed - (int)timeElapsed) * 100f);

            timerText.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, cents);
        }

        if (end)
        {
            Invoke("LoadInitScene", 5f);
        }

        if (timeElapsed == 0)
        {
            SceneManager.LoadScene("DeadScene");
        }
    }

    void LoadInitScene()
    {
        SceneManager.LoadScene("WinScene");
    }

    void OnTriggerEnter(Collider other)
    {
        end = true;
    }
}