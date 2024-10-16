using UnityEngine;
public class ScoreManager : MonoBehaviour
{
    public int playerScore = 0;
    public TextMesh scoreText;

    public void AddScore(int score)
    {
        playerScore += score;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + playerScore.ToString();
    }
}
