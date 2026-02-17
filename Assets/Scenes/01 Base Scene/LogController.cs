using CommandTerminal;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Terminal terminal;
    public string Text = "blleaea";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Capture controller interactions
        if (Gamepad.current != null)
            Debug.Log("Gamepad detected: " + Gamepad.current.displayName);
        else
            Debug.Log("No gamepad found");

    }

    // Update is called once per frame
    void Update()
    {
        // Checking keypresses
        var keyboard = Keyboard.current;

        if (keyboard.wKey.wasPressedThisFrame)
            Debug.Log("W was pressed");

        if (keyboard.aKey.wasPressedThisFrame)
            Debug.Log("A was pressed");

        if (keyboard.sKey.wasPressedThisFrame)
            Debug.Log("S was pressed");

        if (keyboard.dKey.wasPressedThisFrame)
            Debug.Log("D was pressed");

        // Checking controller
        var gamepad = Gamepad.current;

        if (gamepad.leftTrigger.wasPressedThisFrame)
            Debug.Log("Left trigger pressed...");

        if (gamepad.leftShoulder.wasPressedThisFrame)
            Debug.Log("Left shoulder pressed...");

        if (gamepad.leftStickButton.wasPressedThisFrame)
            Debug.Log("Left stick button pressed...");

        // is the left joystick being moved at all?
        Vector2 offset = gamepad.leftStick.ReadValue();
        if (offset.sqrMagnitude > 0 )
            Debug.Log($"Left stick = ({offset.x}, {offset.y})...");


        // is the direction pad being pressed?
        offset = gamepad.dpad.ReadValue();
        if (offset.sqrMagnitude > 0)
            Debug.Log($"D-pad = ({offset.x}, {offset.y})...");

        if (gamepad.buttonSouth.wasPressedThisFrame)
            Debug.Log("A pressed");

        if (gamepad.buttonEast.wasPressedThisFrame)
            Debug.Log("B pressed");

        if (gamepad.buttonNorth.wasPressedThisFrame)
            Debug.Log("Y pressed");

        if (gamepad.buttonWest.wasPressedThisFrame)
            Debug.Log("X pressed");

    }
}
