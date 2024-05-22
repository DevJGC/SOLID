using UnityEngine;
using TMPro;

namespace SolidPrinciples.I
{
    public class Healer : HeroBase, IMovable, IHealable
    {
        [SerializeField] private TextMeshProUGUI textMovable;
        [SerializeField] private TextMeshProUGUI textHealer;

        [SerializeField] private TextMeshProUGUI textAttacker;

        public void Move()
        {
            Debug.Log(heroName + " se puede mover.");
            // Implementar lógica de movimiento
            textMovable.text = heroName + " se puede mover.";

            textAttacker.text = "";
        }

        public void Heal()
        {
            Debug.Log(heroName + " cura al aliado.");
            // Implementar lógica de curación
            textHealer.text = heroName + " cura al aliado.";

            textAttacker.text = "";
        }
    }
}
