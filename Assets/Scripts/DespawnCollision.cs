using UnityEngine;
using UnityEngine.SceneManagement;

public class DespawnCollision : MonoBehaviour
{
    bool killedPlayer;
    public GameObject particlePrefab;
    public GameObject SFX;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (killedPlayer == false)
        {
            Instantiate(particlePrefab, collision.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);

            killedPlayer = true;
            Invoke("RestartLevel", 2.5f);
        }
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
