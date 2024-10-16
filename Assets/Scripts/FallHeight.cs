using UnityEngine;
using UnityEngine.SceneManagement;
public class FallHeight : MonoBehaviour
{
    public float fallHeight = -7f;


    void Update()
    {
        CheckFallHeight();
    }

    void CheckFallHeight()
    {
        RestartLevel();
    }

    void RestartLevel()
    {
        if (transform.position.y < fallHeight)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
