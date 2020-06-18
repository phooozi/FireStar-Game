using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class CountdownBar : MonoBehaviour
{
    Image timerBar;
    public float maxTime = 20f;
    public bool isPaused = false;
    float timeLeft;
    public GameObject timesupText;
    public GameObject timesupScore;
    public GameObject replayBtn;
    public ScoreCounter score;
    public GameObject mainMenu;
    
 
    // Start is called before the first frame update
    void Start()
    {
        timesupScore.SetActive(false);
        timesupText.SetActive (false);
        timerBar = GetComponent<Image> ();
        timeLeft = maxTime;
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        } 
        else
        {
            timesupScore.SetActive(true);
            timesupText.SetActive (true);
            isPaused = true;
            replayBtn.SetActive(true);
            score.ShowHighScore();
            mainMenu.SetActive(true);
        }
    }
}
