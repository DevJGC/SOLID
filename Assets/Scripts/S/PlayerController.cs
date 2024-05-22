using UnityEngine;

namespace SolidPrinciples.S
{
    public class PlayerController : MonoBehaviour
    {
        public float speed = 5.0f;
        public GameObject projectilePrefab;
        public Transform projectileSpawnPoint;

        void Update()
        {
            Move();
            Shoot();
        }

        void Move()
        {
            float move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            transform.Translate(move, 0, 0);
        }

        void Shoot()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Instantiate(projectilePrefab, projectileSpawnPoint.position, Quaternion.identity);
            }
        }
    }
}
