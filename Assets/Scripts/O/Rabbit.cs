using UnityEngine;

namespace SolidPrinciples.O
{
    public class Rabbit : AnimalBase
    {
        void Update()
        {
            Move();
        }

        public override void Move()
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime * 0.8f); // Conejo se mueve un 20% más lento
        }
    }
}
