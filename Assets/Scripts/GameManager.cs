using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject winScreen;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the colliding object is the ball
        if (collision.gameObject.CompareTag("Ball"))
        {
            SceneManager.LoadScene("WinScreen");
        }

    }


}
