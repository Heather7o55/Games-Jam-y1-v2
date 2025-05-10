using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


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
