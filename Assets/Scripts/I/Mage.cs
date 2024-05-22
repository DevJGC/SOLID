using UnityEngine;
using TMPro;

namespace SolidPrinciples.I
{
    public class Mage : HeroBase, IMovable, IAttackable, IHealable
    {
        [SerializeField] private TextMeshProUGUI textMovable;
        [SerializeField] private TextMeshProUGUI textAttacker;
        [SerializeField] private TextMeshProUGUI textHealer;
        

        public void Move()
        {
            Debug.Log(heroName + " se puede mover.");
            // Implementar lógica de movimiento
            textMovable.text = heroName + " se puede mover.";
        }

        public void Attack()
        {
            Debug.Log(heroName + " lanza hechizo.");
            // Implementar lógica de ataque
            textAttacker.text = heroName + " lanza hechizo.";
        }

        public void Heal()
        {
            Debug.Log(heroName + " cura al aliado.");
            // Implementar lógica de curación
            textHealer.text = heroName + " cura al aliado.";
        }
    }
}
