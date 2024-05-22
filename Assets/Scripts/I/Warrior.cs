using UnityEngine;
using TMPro;

namespace SolidPrinciples.I
{
    public class Warrior : HeroBase, IMovable, IAttackable
    {
        [SerializeField] private TextMeshProUGUI textMovable;
        [SerializeField] private TextMeshProUGUI textAttacker;

        // no se utiliza
        [SerializeField] private TextMeshProUGUI textHealer;


        public void Move()
        {
            Debug.Log(heroName + " se puede mover.");
            // Implementar l�gica de movimiento
            textMovable.text = heroName + " se puede mover.";
            // no se utiliza
            textHealer.text = "";
        }

        public void Attack()
        {
            Debug.Log(heroName + " empu�a la espada!");
            // Implementar l�gica de ataque
            textAttacker.text = heroName + " empu�a la espada!";
            // no se utiliza
            textHealer.text = "";
        }
    }
}
