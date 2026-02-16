using UnityEngine;
using UnityEngine.InputSystem;

public class Sensor : MonoBehaviour
{
    public float SenseDistance = 1;
    public float RepulseForce = 100;

    // Update is called once per frame
    void Update()
    {
        // Cast a ray up to sense distance, does it hit anything?
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        // Does it hit anything?
        if (Physics.Raycast(ray, out hit, SenseDistance))
        {
            GameObject firstHitObject = hit.collider.gameObject;

            float ForceFactor = (SenseDistance - hit.distance) / SenseDistance;
            transform.parent.GetComponent<Rigidbody>().AddForce(- RepulseForce * ForceFactor * transform.forward);

            Debug.Log($"Sensed {firstHitObject.name}");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, 
            transform.position + transform.forward * SenseDistance);
    }
}
