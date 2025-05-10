using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("MainGame");
        Debug.Log("Game Is Starting!");
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