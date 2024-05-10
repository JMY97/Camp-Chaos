using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        transform.Translate(0f, 0f, speed * Time.deltaTime);
        //transform.Rotate(0, speed, 0);
        //transform.localScale += new Vector3(0.01f, 0, 0);

        //float horizontalInput = Input.GetAxis("Horizontal");
        //float verticalInput = Input.GetAxis("Vertical");
        //Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        //transform.Translate(movementDirection * speed * Time.deltaTime);
    }
}
