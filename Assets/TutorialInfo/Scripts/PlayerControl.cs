using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame

    public float speed = 20;

    public float TurnSpeed;

    public float horizontalInput;

    public float forwardInput;

    void Update()
    {
        //move vehicle forward
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * TurnSpeed * horizontalInput);
        transform.Rotate(Vector3.up, TurnSpeed * horizontalInput * Time.deltaTime);
    }
}