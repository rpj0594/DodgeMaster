using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float jumpHeight;
    public float speed;
    public float intialForce = 200f;
    public float rotationSpeed = 500f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector3.forward * intialForce);
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpHeight);
        }

        Vector3 rotation = new Vector3(moveVertical, 0.0f, moveHorizontal);
        rb.AddForce(rotation * rotationSpeed * Time.deltaTime);



    }
}
