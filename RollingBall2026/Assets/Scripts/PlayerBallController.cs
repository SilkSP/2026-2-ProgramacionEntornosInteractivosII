using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBallController : MonoBehaviour
{
    private Rigidbody rb;

    public Vector3 movementDirection;

    public float movementSpeed = 2f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 inputMove = context.ReadValue<Vector2>();
        Debug.Log(inputMove);

        movementDirection = new Vector3(inputMove.x, 0f, inputMove.y);

        //rb.AddForce(movementDirection, ForceMode.Force);
    }


    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown("X"))
        
    }


    private void FixedUpdate()
    {

        rb.AddForce(movementDirection * movementSpeed, ForceMode.Force);

        //Vector3 force = new Vector3(1f, 0f, 0f);

        //rb.AddForce(force);
    }
}
