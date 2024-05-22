using UnityEngine;

namespace SolidPrinciples.O
{
    public class Dog : AnimalBase
    {
        void Update()
        {
            Move();
        }

        public override void Move()
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime * 1.2f); // Perro se mueve un 20% más rápido
        }
    }
}
