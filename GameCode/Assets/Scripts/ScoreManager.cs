using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public PlayfabManager playfabManager;
    public GameObject compcanvas;
    public GameObject endofgameCanvas;

    public int highscore;
    public Text scoreText, highscoreText;
    public string sceneName;
    int score = 0;

    private void Start()
    {
        //Loadhighscore();
        highscore = PlayerPrefs.GetInt("highscore", 0);
        if (sceneName != "Level1")
        {
            Loadscore();
        }
    }

    public void Update()
    {
        scoreText.text = score.ToString();
        highscoreText.text = highscore.ToString();

        if (score > highscore)
        {
            highscore = score;
            Save();
        }
    }

    public void AddScore(int amount)
    {
        score += amount;
        Save();
    }


    //public void SubtractScore(int amount)
    //{
    //    score -= amount;
    //    Save();
    //}

    public void AddScoreif(int amount)
    {
        if (FireBaseLabel.LabelByPlayer == "Casing" || FireBaseLabel_lvl2.LabelByPlayer == "Module/Stack" || Label_lvl3.LabelByPlayer == "Coolant Connections" ||
            FireBaseLabel_lvl4.LabelByPlayer == "High Voltage Cables" || FireBaseLabel_lvl5.LabelByPlayer == "Bus Bar" || FireBaseLabel_lvl6.LabelByPlayer == "BMS")
        {
            score += amount;
        }
    }

    public void Save()
    {
        PlayerPrefs.SetInt("score", score);
        PlayerPrefs.SetInt("highscore", highscore);
    }

    public void Loadhighscore()
    {
        highscore = PlayerPrefs.GetInt("highscore");
    }

    public void Loadscore()
    {
        score = PlayerPrefs.GetInt("score");
    }

    public void GameOver()
    {
        playfabManager.SendLeaderboard(score);
    }

    public void BonusRound()
    {
        if (score > 100)
        {
            compcanvas.SetActive(true);
        }
        else
        {
            compcanvas.SetActive(false);
            endofgameCanvas.SetActive(true);
        }
    }
}
