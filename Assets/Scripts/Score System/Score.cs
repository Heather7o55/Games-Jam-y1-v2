using UnityEngine;

public class Score : MonoBehaviour
{
    public int currentScore = 0;
    // public int scoreGoal = 100000; // Could use this to set a goal

    public int maxLives = 3;
    public int currentLives = 0;

    private void start()
    {
        currentLives = maxLives;
        Debug.Log("Player Has " + currentLives + " Left");
    }

    public void TakeLives(int amount)
    {
        currentLives += amount;
        Debug.Log("Player Has " + currentLives + " Left");
    }

    public void AddScore(int amount)
    {
        currentScore += amount;
        Debug.Log("Score " + currentScore);
    }

    public void ResetScore()
    {
        Debug.Log("Score Reset From " + currentScore + " To 0");
        currentScore = 0;
        
    }
}