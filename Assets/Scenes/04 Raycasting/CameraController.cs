using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    public float RotateFactor = 45;
    public float MoveFactor = 1;

    // Update is called once per frame
    void Update()
    {
        // Capture controller interactions
        var gamepad = Gamepad.current;
        if (gamepad == null) return;

        // Rotate left/right based on right joystick's left/right position
        Vector2 rightJoystick = gamepad.rightStick.ReadValue();
        transform.eulerAngles += Vector3.up * (rightJoystick.x * RotateFactor * Time.deltaTime);
        transform.eulerAngles += Vector3.right * (rightJoystick.y * RotateFactor * Time.deltaTime);

        // Move based on left joystick's left/right position
        Vector2 leftJoystick = gamepad.leftStick.ReadValue();
        transform.position = transform.position
            + transform.forward * (leftJoystick.y * MoveFactor * Time.deltaTime)
            + transform.right * (leftJoystick.x * MoveFactor * Time.deltaTime);
    }
}
