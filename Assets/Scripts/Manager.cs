using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public float startTime = 30.0f;
    private float timer;
    private int iTimer;

    public Text timerText;

    public GameObject menuScreen;

    void Start()
    {
        Time.timeScale = 1;
        timer = startTime;
    }

    void Update()
    {
        if(timer > 0) {
            timer -= Time.deltaTime;
            iTimer = (int) timer;
            timerText.text = iTimer.ToString();
        } else {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            menuScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Exit()
    {
        Application.Quit();
    }

}
