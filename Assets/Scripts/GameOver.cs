using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject gameoverText;
    [SerializeField] GameObject pauseButton;
    [SerializeField] GameObject restartButton;  
    [SerializeField] GameObject quitButton;

    const string PLAYER_TAG = "Player";

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(PLAYER_TAG))
        {
            pauseButton.SetActive(false);
            gameoverText.SetActive(true);
            restartButton.SetActive(true);
            quitButton.SetActive(true);
            Time.timeScale = 0f; // Pause the game
        }
    }
}
