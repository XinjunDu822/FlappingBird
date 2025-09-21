using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public GameObject gameOverScreen;
    public bool isGameOver = false;
    [ContextMenu("Increase Score")]

    void Start()
    {
        updateHighScore();
    }
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = "Score: " + playerScore.ToString();
        checkHighScore();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
 
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        isGameOver = true;
    }

    public void returnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    private void checkHighScore()
    {
        if (playerScore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", playerScore);
            updateHighScore();
        }
    }
    public void updateHighScore()
    {
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore").ToString();
    }
}
