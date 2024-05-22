using UnityEngine;

namespace SolidPrinciples.O
{
    public abstract class AnimalBase : MonoBehaviour, IMovable
    {
        public float speed;
        public abstract void Move();
    }
}
