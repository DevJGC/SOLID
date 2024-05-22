using UnityEngine;

namespace SolidPrinciples.S
{
    public class Projectile : MonoBehaviour
    {
        public float speed = 10.0f;

        void Update()
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Enemy"))
            {
                Destroy(other.gameObject);
                Destroy(gameObject);
                ScoreManager.instance.AddScore(10);
            }
        }
    }
}
