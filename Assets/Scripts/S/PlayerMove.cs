using UnityEngine;

namespace SolidPrinciples.S
{
    public class PlayerMove : MonoBehaviour
    {
        public float speed = 5.0f;

        void Update()
        {
            Move();
        }

        void Move()
        {
            float move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            transform.Translate(move, 0, 0);
        }
    }
}