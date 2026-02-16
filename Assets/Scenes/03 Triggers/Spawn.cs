
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject SpawnPrefab;
    public float SpawnCooldown = 1;
    private float SpawnTimer;

    // Update is called once per frame
    void Update()
    {
        // Don't do anything unless it's time to do so.
        SpawnTimer -= Time.deltaTime;
        if (SpawnTimer > 0) return;

        // Clone/spawn prefab and place.
        GameObject spawned = GameObject.Instantiate(SpawnPrefab, 
            transform.position, 
            Quaternion.identity);

        // Reset timer
        SpawnTimer = SpawnCooldown;
    }
}
