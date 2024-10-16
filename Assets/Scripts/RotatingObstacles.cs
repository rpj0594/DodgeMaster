using UnityEngine;

public class RotatingObstacles : MonoBehaviour
{
    public float rotationSpeed = 500f;
    public Vector3 rotationAxis = Vector3.up;

    void Update()
    {
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
    }







}
