using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public string sceneName;

    public void SceneChange()
    {
        SceneManager.LoadScene("Level 1");
    }


    public void ExitGame()
    {
        Application.Quit();
    }

}
