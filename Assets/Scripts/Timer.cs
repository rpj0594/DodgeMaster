using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    float elaspedTime;

    // Update is called once per frame
    void Update()
    {
        elaspedTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(elaspedTime / 60);
        int seconds = Mathf.FloorToInt(elaspedTime % 60);
        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
