using CommandTerminal;
using UnityEngine;
using UnityEngine.InputSystem;

public class DirectInputController : MonoBehaviour
{
    public float RotateFactor = 45;
    public float ForwardFactor = 1;

    public float JumpForce = 500;
    public float JumpCooldown = 1;
    private float JumpTimer = 0;

    public Terminal terminal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Capture controller interactions
        var gamepad = Gamepad.current;
        if (gamepad == null) return;

        // Get direction that left joystick is pointing. x and y both
        // range from -1 to +1
        Vector2 direction = gamepad.leftStick.ReadValue();

        // Rotate left/right based on joystick's left/right position
        transform.eulerAngles += Vector3.up * (direction.x * RotateFactor * Time.deltaTime);

        // Move forwards/backwards based on joystick's up/down position.
        transform.position += transform.forward * (direction.y * ForwardFactor * Time.deltaTime);

        // Apply jump force, then start a cool down before can jump again.
        JumpTimer -= Time.deltaTime;
        if ((JumpTimer <= 0) && gamepad.rightTrigger.IsPressed())
        {
            Vector3 force = Vector3.up * JumpForce;
            Rigidbody rigidbody = GetComponent<Rigidbody>();
            rigidbody.AddForce(force);

            JumpTimer = JumpCooldown;
        }

        // Toggle Command Terminal
        if (gamepad.leftTrigger.wasPressedThisFrame)
        {
            Debug.Log("Terminal state toggled...");
            terminal.ToggleState(terminal.IsClosed? TerminalState.OpenSmall : TerminalState.Close);
        }
    }
}
