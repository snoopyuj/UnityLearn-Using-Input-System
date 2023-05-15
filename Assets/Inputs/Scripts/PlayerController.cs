using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    public float speed = 1f;

    private Rigidbody rb = null;
    private float movementX = 0f;
    private float movementY = 0f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        var move = new Vector3(movementX, 0f, movementY);

        rb.AddForce(move * speed);
    }

    private void OnMove(InputValue _moveVal)
    {
        var moveVector = _moveVal.Get<Vector2>();

        movementX = moveVector.x;
        movementY = moveVector.y;
    }
}