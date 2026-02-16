using UnityEngine;

public class Destroy : MonoBehaviour
{
    public string tagToDestroy = "Destroyable";

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == tagToDestroy)
        {
            float timeToLive = Random.Range(0.0f, 3.0f );
            Destroy(other.gameObject, timeToLive);
        }
    }
}
