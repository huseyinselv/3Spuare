using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndGameSC : MonoBehaviour
{
    [SerializeField] TMP_Text scoreDisplayText;
    [SerializeField] TMP_Text highScoreText;
    float gecicizaman;
    private void Start()
    {
        Destroy(GameObject.Find("Canvas"));
        gecicizaman = TimerSC.zaman;
        if (PlayerPrefs.GetInt("highScore") == 0)
        {
            PlayerPrefs.SetInt("highScore", (int) TimerSC.zaman);

        } else if (TimerSC.zaman < PlayerPrefs.GetInt("highScore") )
        {
            PlayerPrefs.SetInt("highScore", (int)TimerSC.zaman);
        } else
        {
            gecicizaman = TimerSC.zaman;
        }
        ScoreDisplay();
        HighScoreDisplay();

        
    }
    private void ScoreDisplay()
    {
        scoreDisplayText.text = " Your Score : " + (int)TimerSC.zaman;
    }
    private void HighScoreDisplay()
    {
        highScoreText.text = " High Score : " + PlayerPrefs.GetInt("highScore").ToString();
    }
}
