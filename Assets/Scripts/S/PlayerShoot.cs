using UnityEngine;

namespace SolidPrinciples.S
{
    public class PlayerShoot : MonoBehaviour
    {
        public GameObject projectilePrefab;
        public Transform projectileSpawnPoint;

        void Update()
        {
            Shoot();
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