using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int currentScore = 0;
    // public int scoreGoal = 100000; // Could use this to set a goal

    public int maxLives = 3;
    public static int currentLives = 0;

    private void Start()
    {
        currentLives = maxLives;
        Debug.Log("Player Has " + currentLives + " Left");
    }

    public static void TakeLives(int amount)
    {
        currentLives -= amount;
        Debug.Log("Player Has " + currentLives + " Left");
    }

    public static void AddScore(int amount)
    {
        currentScore += amount;
        Debug.Log("Score " + currentScore);
    }

    public static void ResetScore()
    {
        Debug.Log("Score Reset From " + currentScore + " To 0");
        currentScore = 0;
    }
    public static void GameOver()
    {
        SceneManager.LoadScene("Game Over");
    }
}