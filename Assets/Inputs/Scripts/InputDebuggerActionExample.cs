using UnityEngine;
using UnityEngine.InputSystem;

public class InputDebuggerActionExample : MonoBehaviour
{
    public InputAction exampleAction = null;

    private void OnEnable()
    {
        exampleAction?.Enable();
    }
}