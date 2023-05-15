using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float speed = 10f;

    private PlayerControls controls = null;
    private Vector2 move = Vector2.zero;
    private Transform trans = null;

    private void Awake()
    {
        trans = transform;

        controls = new PlayerControls();
        controls.Player.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Player.Move.canceled += ctx => move = Vector2.zero;
    }

    private void OnEnable()
    {
        controls.Player.Enable();
    }

    private void OnDisable()
    {
        controls.Player.Disable();
    }
    private void FixedUpdate()
    {
        var movement = new Vector3(move.x, 0f, move.y) * speed * Time.deltaTime;

        trans.Translate(movement, Space.World);
    }

    private void SendMessage(Vector2 coordinates)
    {
        Debug.Log("Thumb-stick coordinates = " + coordinates);
    }
}