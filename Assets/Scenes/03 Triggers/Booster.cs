using UnityEngine;

public class Booster : MonoBehaviour
{
    public float BoostForce = 10;

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        rb?.AddForce(Vector3.up * BoostForce);
    }
}
