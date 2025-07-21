using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnInterval = 2f;
    public float obstacleSpeed = 3f;
    public float minY = -2f, maxY = 2f;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", 1f, spawnInterval);
    }

    void SpawnObstacle()
    {
        float y = Random.Range(minY, maxY);
        GameObject obs = Instantiate(obstaclePrefab, new Vector3(10f, y, 0), Quaternion.identity);
        obs.AddComponent<Rigidbody2D>().gravityScale = 0;
        obs.GetComponent<Rigidbody2D>().linearVelocity = Vector2.left * obstacleSpeed;
        Destroy(obs, 10f);
    }
}
