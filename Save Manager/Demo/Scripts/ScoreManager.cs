// Reference to SaveManager
using Racer.SaveManager;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

internal class ScoreManager : MonoBehaviour
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
        _highscore = SaveManager.GetInt("Highscore");

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

        // You can choose not to save Immediately.
        SaveManager.SaveInt("Highscore", _highscore);
    }

    /// <summary>
    /// It's advisable to reload the current scene here,
    /// so as to apply changes after the deletion process.
    /// </summary>
    public void DeleteSave()
    {
        // Clears all saved preferences
        SaveManager.ClearAllPrefs();

        // Reloads the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
