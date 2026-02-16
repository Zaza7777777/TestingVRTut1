using UnityEngine;
using UnityEngine.InputSystem;

public class Raycaster : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // If left mouse button was clicked, then determine what was clicked on
        Mouse mouse = Mouse.current;
        if (!mouse.leftButton.wasPressedThisFrame) return;

        // Get a ray starting at the camera and passing through the point
        // clicked/tapped on the screen.
        Ray ray = Camera.main.ScreenPointToRay(mouse.position.ReadValue());
        RaycastHit hit;

        // Does it hit anything?
        if (Physics.Raycast(ray, out hit))
        {
            GameObject firstHitObject = hit.collider.gameObject;
            Debug.Log($"Clicked on {firstHitObject.name}");
        }
    }
}
