using UnityEngine;
using TMPro;

namespace SolidPrinciples.I
{
    public class Healer : HeroBase, IMovable, IHealable
    {
        [SerializeField] private TextMeshProUGUI textMovable;
        [SerializeField] private TextMeshProUGUI textHealer;

        // no se utiliza
        [SerializeField] private TextMeshProUGUI textAttacker;

        public void Move()
        {
            Debug.Log(heroName + " se puede mover.");
            // Implementar l�gica de movimiento
            textMovable.text = heroName + " se puede mover.";
            // no se utiliza
            textAttacker.text = "";
        }

        public void Heal()
        {
            Debug.Log(heroName + " cura al aliado.");
            // Implementar l�gica de curaci�n
            textHealer.text = heroName + " cura al aliado.";
            // no se utiliza
            textAttacker.text = "";
        }
    }
}
