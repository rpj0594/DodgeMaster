using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        //Next level will load when the player with tag ball crosses finish line
        if (other.gameObject.CompareTag("Ball"))
        {
            SceneManager.LoadScene("Level 2");
        }

    }



}
