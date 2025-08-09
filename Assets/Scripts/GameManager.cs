using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameTitle;
    [SerializeField] GameObject gameStartButton;
    [SerializeField] GameObject pauseButton;
    [SerializeField] GameObject resumeButton;
    [SerializeField] GameObject restartButton;
    [SerializeField] GameObject quitButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 0f; // Pause the game at the start
    }

    public void StartGame()
    {
        gameTitle.SetActive(false);
        gameStartButton.SetActive(false);
        quitButton.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f; // Resume the game
    }

    public void ShowPauseMenu()
    {
        pauseButton.SetActive(false);
        resumeButton.SetActive(true);
        restartButton.SetActive(true);
        quitButton.SetActive(true);
        Time.timeScale = 0f; // Pause the game
    }

    public void ResumeGame()
    {
        pauseButton.SetActive(true);
        resumeButton.SetActive(false);
        restartButton.SetActive(false);
        quitButton.SetActive(false);
        Time.timeScale = 1f; // Resume the game
    }

    public void RestartGame()
    {
        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
