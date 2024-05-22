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
            // Implementar lógica de movimiento
            textMovable.text = heroName + " se puede mover.";
            // no se utiliza
            textHealer.text = "";
        }

        public void Attack()
        {
            Debug.Log(heroName + " empuña la espada!");
            // Implementar lógica de ataque
            textAttacker.text = heroName + " empuña la espada!";
            // no se utiliza
            textHealer.text = "";
        }
    }
}
