using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class MenuScript : MonoBehaviour
{
    public TextMeshProUGUI menuHighScoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void onPlayButton()
    {
        SceneManager.LoadScene("Game"); 
    }
    private void Start()
    {
        menuHighScoreText.text = "Current High Score: " + PlayerPrefs.GetInt("HighScore").ToString();
    }

    public void onQuitButton()
    {
        Application.Quit();
    }
}
