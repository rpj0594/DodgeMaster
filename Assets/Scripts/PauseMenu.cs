using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    public void Pause()
    {
        // When button is pressed the pause menu will open
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        // When button is pressed the pause button will close 
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void Restart()
    {
        //When button is pressed the game will reload scene from the start of the level
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void Home()
    {
        //When home button is pressed the main menu will open
        SceneManager.LoadScene("Main Menu");
    }

    public void Start()
    {
        //When the start button is pressed the pause menu will be disabled
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
