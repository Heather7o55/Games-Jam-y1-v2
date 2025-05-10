using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("Main Game");
        Debug.Log("Game Is Starting!");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
        Debug.Log("Returning To Menu!");
    }

    public void Setting()
    {
        
        Debug.Log("Opening Settings!");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exiting Game!");
    }
}