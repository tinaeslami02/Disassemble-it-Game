using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static Timer instance;
    public Bonus_PlayfabManager playfabManager;

    public float timeValue = 10;
    public Text timeText;
    public GameObject EndSceneCanvas;
    public Text bonusscoreText;
    int bonusroundscore = 0;
    public string sceneName;


    void Update()
    {
        bonusscoreText.text = bonusroundscore.ToString();
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }

        DisplayTime(timeValue);
        saveBonusRoundScore();
    }

    public void bonusaddscore(int amount)
    {
        bonusroundscore += amount;
        saveBonusRoundScore();
    }

    public void saveBonusRoundScore()
    {
        PlayerPrefs.SetInt("bonusroundscore", bonusroundscore);
    }

    public void loadBonusRoundScore()
    {
        bonusroundscore = PlayerPrefs.GetInt("bonusroundscore");
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
            EndSceneCanvas.SetActive(true);
            playfabManager.SendLeaderboard(bonusroundscore);
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
