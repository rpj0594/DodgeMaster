using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{


    public void Restart()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Home()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
