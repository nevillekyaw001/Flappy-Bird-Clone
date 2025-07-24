using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    [SerializeField] TextMeshProUGUI currentScore;
    [SerializeField] TextMeshProUGUI highScore;

    int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    // Update is called once per frame
    void Start()
    {
        currentScore.text = score.ToString();
        highScore.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
        UpdateHighscore();
    }

    public void UpdateHighscore()
    {
        if (score > PlayerPrefs.GetInt("Highscore"))
        {
            PlayerPrefs.SetInt("Highscore", score);
            highScore.text = score.ToString();
        }
    }

    public void UpdateScore()
    {
        score++;
        currentScore.text = score.ToString();
        UpdateHighscore();
    }
}
