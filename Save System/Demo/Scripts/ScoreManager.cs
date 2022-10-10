// Reference to SaveSystem.cs
using Racer.SaveSystem;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }

    private int _score;
    private int _highscore;

    [SerializeField] private Text scoreText;
    [SerializeField] private Text highscoreText;


    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        // Uses target type's default value if value does not exist initially.
        _highscore = SaveSystem.GetData<int>("Highscore");

        highscoreText.text = "HIGHSCORE: " + _highscore;
    }

    public void AddScore(int amount)
    {
        _score += amount;

        scoreText.text = "SCORE: " + _score;

        // Whenever the current score exceeds the saved-highscore,
        // Update the highscore to the current score
        if (_highscore >= _score) return;

        _highscore += amount;

        highscoreText.text = "HIGHSCORE: " + _highscore;

        SaveSystem.SaveData("Highscore", _highscore);
    }

    /// <summary>
    /// It's advisable to reload the current scene here,
    /// so as to apply changes after the deletion process.
    /// </summary>
    public void DeleteSave()
    {
        // Deletes the current save file
        SaveSystem.DeleteSaveFile();

        // Reloads the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
