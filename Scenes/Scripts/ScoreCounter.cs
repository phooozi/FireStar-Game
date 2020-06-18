using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
	public static int scoreValue = 0;
	Text score;
    public Text highScore;

    // Start is called before the first frame update
    void Start()
    {
        scoreValue = 0;
        score = GetComponent<Text> ();

    }

    // Update is called once per frame
    void Update()
    {
        score.text = scoreValue.ToString();
       
    }
    public void ShowHighScore()
    {
        if (ScoreCounter.scoreValue > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", ScoreCounter.scoreValue);
            highScore.text = ScoreCounter.scoreValue.ToString();
        }
        highScore.gameObject.SetActive(true);
        highScore.text = "High Score: " + PlayerPrefs.GetInt("HighScore", scoreValue).ToString();
    }

}


// To increase the score in the text...
// ScoreCounter.scoreValue += 1;
