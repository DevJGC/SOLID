using UnityEngine;

namespace SolidPrinciples.O
{
    public class Cat : AnimalBase
    {
        void Update()
        {
            Move();
        }

        public override void Move()
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
