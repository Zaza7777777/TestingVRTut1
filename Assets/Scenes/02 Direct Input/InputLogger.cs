using CommandTerminal;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputLogger : MonoBehaviour
{
    void Start()
    {
        Terminal.Log("Logging input captured from input devices.");
    }

    void Update()
    {
        // Capture keyboard presses

        // Capture mouse presses

        // Capture controller interactions
        var gamepad = Gamepad.current;
        if (gamepad == null) return;

        if (gamepad.rightTrigger.wasPressedThisFrame) 
            Terminal.Log("Gamepad.RightTrigger pressed...");
        if (gamepad.rightTrigger.wasReleasedThisFrame) 
            Terminal.Log("Gamepad.RightTrigger released...");
        if (gamepad.rightShoulder.wasPressedThisFrame)
            Terminal.Log("Gamepad.RightShoulder pressed...");
        if (gamepad.rightShoulder.wasReleasedThisFrame)
            Terminal.Log("Gamepad.RightShoulder released...");
    }
}
