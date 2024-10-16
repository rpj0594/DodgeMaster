using UnityEngine;

public class MovingObstacles : MonoBehaviour
{
    public ScoreManager scoreManager;

    public Vector3 pointA;
    public Vector3 pointB;
    public float speed;

    private bool movingToB = true;


    void Update()
    {
        if (movingToB)
        {
            transform.position = Vector3.MoveTowards(transform.position, pointB, speed * Time.deltaTime);
            if (transform.position == pointB)
            {
                movingToB = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, pointA, speed * Time.deltaTime);
            if (transform.position == pointA)
            {
                movingToB = true;
            }
        }
    }


}
