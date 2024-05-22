using UnityEngine;

namespace SolidPrinciples.S
{
    public class EnemyManager : MonoBehaviour
    {
        public GameObject enemyPrefab;
        public float spawnRate = 2.0f;
        public Transform[] spawnPoints;
        public float enemySpeed = 1.0f;

        void Start()
        {
            InvokeRepeating("SpawnEnemy", spawnRate, spawnRate);
        }

        void SpawnEnemy()
        {
            int spawnIndex = Random.Range(0, spawnPoints.Length);
            GameObject enemy = Instantiate(enemyPrefab, spawnPoints[spawnIndex].position, Quaternion.identity);
            enemy.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -enemySpeed);
        }
    }
}
